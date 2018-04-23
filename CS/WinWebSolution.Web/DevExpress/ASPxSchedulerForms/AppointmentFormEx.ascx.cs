/*
{************************************************************************************}
{                                                                                    }
{   DO NOT MODIFY THIS FILE!                                                         }
{                                                                                    }
{   It will be overwritten without prompting when a new version becomes              }
{   available. All your changes will be lost.                                        }
{                                                                                    }
{   This file contains the default template and is required for the form             }
{   rendering. Improper modifications may result in incorrect behavior of            }
{   the appointment form.                                                            }
{                                                                                    }
{   In order to create and use your own custom template, perform the following       }
{   steps:                                                                           }
{       1. Save a copy of this file with a different name in another location.       }
{       2. Specify the file location as the 'OptionsForms.AppointmentFormTemplateUrl'}
{          property of the ASPxScheduler control.                                    }
{       3. If you need custom fields to be displayed and processed, you should       }
{          accomplish steps 4-9; otherwise, go to step 10.                           }
{       4. Create a class, derived from the AppointmentFormTemplateContainer,        }
{          containing custom properties. This class definition can be located        }
{          within a class file in the App_Code folder.                               }
{       5. Replace AppointmentFormTemplateContainer references in the template       }
{          page with the name of the class you've created in step 4.                 }
{       6. Handle the AppointmentFormShowing event to create an instance of the      }
{          template container class, defined in step 4, and specify it as the        }
{          destination container instead of the default one.                         }
{       7. Define a class, which inherits from the                                   }
{          DevExpress.Web.ASPxScheduler.Internal.AppointmentFormController.          }
{          This class provides data exchange between the form and the appointment.   }
{          You should override ApplyCustomFieldsValues() method of the base class.   }
{       8. Define a class, which inherits from the                                   }
{          DevExpress.Web.ASPxScheduler.Internal.AppointmentFormSaveCallbackCommand. }
{          This class creates an instance of the AppointmentFormController inheritor }
{          (defined in step 7) via the CreateAppointmentFormController method and    }
{          overrides the AssignControllerValues method  of the base class to collect }
{          user data from the form's editors.                                        }
{       9. Handle the BeforeExecuteCallbackCommand event. The event handler code     }
{          should create an instance of the class defined in step 8, and specify it  }
{          as the destination command instead of the default one.                    }
{      10. Modify the overall appearance of the page and its layout.                 }
{                                                                                    }
{************************************************************************************}
*/
using System;
using System.Web.UI;
using DevExpress.XtraScheduler;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using System.Collections;
using System.Collections.Generic;
using DevExpress.XtraScheduler.Localization;
using DevExpress.Web.ASPxScheduler.Controls;
using DevExpress.Web.ASPxClasses;

public partial class AppointmentFormEx : SchedulerFormControl {
	AppointmentRecurrenceControl recurrenceControl;

    public bool CanShowReminders {
        get {
            return ((AppointmentFormTemplateContainer)Parent).Control.Storage.EnableReminders;
        }
    }
    public bool ResourceSharing {
        get {
            return ((AppointmentFormTemplateContainer)Parent).Control.Storage.ResourceSharing;
        }
    }
    public IEnumerable ResourceDataSource {
        get {
            return ((AppointmentFormTemplateContainer)Parent).ResourceDataSource;
        }
    }
	public AppointmentRecurrenceControl RecurrenceControl { get { return recurrenceControl; } }

	protected void Page_Load(object sender, EventArgs e) {
		RenderRecurrenceControl(false);
		//PrepareChildControls();
		tbSubject.Focus();
	}
	protected override void Render(System.Web.UI.HtmlTextWriter writer) {
		AppointmentFormTemplateContainer container = (AppointmentFormTemplateContainer)Parent;
		ASPxScheduler control = container.Control;
		RecurrenceControl.EditorsInfo = new EditorsInfo(control, control.Styles.FormEditors, control.Images.FormEditors, control.Styles.Buttons);
		RecurrenceControl.Visible = chkRecurrence.Checked && chkRecurrence.Visible;
		base.Render(writer);
	}
	public override void DataBind() {
		base.DataBind();
		AppointmentFormTemplateContainer container = (AppointmentFormTemplateContainer)Parent;
		Appointment apt = container.Appointment;
		edtLabel.SelectedIndex = apt.LabelId;
		edtStatus.SelectedIndex = apt.StatusId;

        PopulateResourceEditors(apt, container);

		chkRecurrence.Visible = container.ShouldShowRecurrence;
		//AppointmentRecurrenceForm1.Visible = container.ShouldShowRecurrence;

		if(container.Appointment.HasReminder) {
			cbReminder.Value = container.Appointment.Reminder.TimeBeforeStart.ToString();
			chkReminder.Checked = true;
		}
		else {
			cbReminder.ClientEnabled = false;
		}

		btnOk.ClientSideEvents.Click = container.SaveHandler;
		btnCancel.ClientSideEvents.Click = container.CancelHandler;
		btnDelete.ClientSideEvents.Click = container.DeleteHandler;
	}
    void PopulateResourceEditors(Appointment apt, AppointmentFormTemplateContainer container) {
        if(ResourceSharing) {
            ASPxListBox edtMultiResource = ddResource.FindControl("edtMultiResource") as ASPxListBox;
            if(edtMultiResource == null)
                return;
            SetListBoxSelectedValues(edtMultiResource, apt.ResourceIds);
            List<String> multiResourceString = GetListBoxSeletedItemsText(edtMultiResource);
            string stringResourceNone = SchedulerLocalizer.GetString(SchedulerStringId.Caption_ResourceNone);
            ddResource.Value = stringResourceNone;
            if(multiResourceString.Count > 0)
                ddResource.Value = String.Join(", ", multiResourceString.ToArray());
            ddResource.JSProperties.Add("cp_Caption_ResourceNone", stringResourceNone);
        }
        else {
            if(!Object.Equals(apt.ResourceId, Resource.Empty.Id))
                edtResource.Value = apt.ResourceId.ToString();
            else
                edtResource.Value = SchedulerIdHelper.EmptyResourceId;
        }
    }
    List<String> GetListBoxSeletedItemsText(ASPxListBox listBox) {
        List<String> result = new List<string>();
        foreach(ListEditItem editItem in listBox.Items) {
            if(editItem.Selected)
                result.Add(editItem.Text);
        }
        return result;
    }
    void SetListBoxSelectedValues(ASPxListBox listBox, IEnumerable values) {
        listBox.Value = null;
        foreach(object value in values) {
            ListEditItem item = listBox.Items.FindByValue(value.ToString());
            if(item != null)
                item.Selected = true;
        }
    } 
	protected override ASPxEditBase[] GetChildEditors() {
		ASPxEditBase[] edits = new ASPxEditBase[] {
			lblSubject, tbSubject,
			lblLocation, tbLocation,
			lblLabel, edtLabel,
			lblStartDate, edtStartDate,
			lblEndDate, edtEndDate,
			lblStatus, edtStatus,
			lblAllDay, chkAllDay,
			lblResource, edtResource,
			tbDescription, cbReminder,
            ddResource
		};
		return edits;
	}
	protected override ASPxButton[] GetChildButtons() {
		ASPxButton[] buttons = new ASPxButton[] {
			btnOk, btnCancel, btnDelete
		};
		return buttons;
	}
	protected void OnCallback(object sender, CallbackEventArgsBase e) {
		RenderRecurrenceControl(true);
	}
	protected void RenderRecurrenceControl(bool isRecurring) {
		if(this.recurrenceControl != null) {
			this.recurrenceControl.Visible = isRecurring;
			return;
		}
		AppointmentFormTemplateContainer container = (AppointmentFormTemplateContainer)Parent;
		this.recurrenceControl = new AppointmentRecurrenceControl();
		recurrenceControl.ID = "RecurrenceControl1";
		recurrenceControl.Visible = isRecurring;//container.ShouldShowRecurrence;
		recurrenceControl.DayNumber = container.RecurrenceDayNumber;
		recurrenceControl.End = container.RecurrenceEnd;
		recurrenceControl.Month = container.RecurrenceMonth;
		recurrenceControl.OccurrenceCount = container.RecurrenceOccurrenceCount;
		recurrenceControl.Periodicity = container.RecurrencePeriodicity;
		recurrenceControl.RecurrenceRange = container.RecurrenceRange;
		recurrenceControl.Start = container.RecurrenceStart;
		recurrenceControl.WeekDays = container.RecurrenceWeekDays;
		recurrenceControl.WeekOfMonth = container.RecurrenceWeekOfMonth;
		recurrenceControl.RecurrenceType = container.RecurrenceType;
		recurrenceControl.IsFormRecreated = container.IsFormRecreated;
		RecurrencePanel.Controls.Add(recurrenceControl);
		recurrenceControl.EditorsInfo = new EditorsInfo(container.Control, container.Control.Styles.FormEditors, container.Control.Images.FormEditors, container.Control.Styles.Buttons);
	}
}
