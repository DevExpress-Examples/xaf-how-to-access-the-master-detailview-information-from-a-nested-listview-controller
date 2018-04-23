/*
{************************************************************************************}
{                                                                                    }
{   DO NOT MODIFY THIS FILE!                                                         }
{                                                                                    }
{   It will be overwritten without prompting when a new version becomes              }
{   available. All your changes will be lost.                                        }
{                                                                                    }
{   This file contains the default template and is required for the appointment      }
{   rendering. Improper modifications may result in incorrect appearance of the      }
{   appointment.                                                                     }
{                                                                                    }
{   In order to create and use your own custom template, perform the following       }
{   steps:                                                                           }
{       1. Save a copy of this file with a different name in another location.       }
{       2. Add a Register tag in the .aspx page header for each template you use,    }
{          as follows: <%@ Register Src="PathToTemplateFile" TagName="NameOfTemplate"}
{          TagPrefix="ShortNameOfTemplate" %>                                        }
{       3. In the .aspx page find the tags for different scheduler views within      }
{          the ASPxScheduler control tag. Insert template tags into the tags         }
{          for the views which should be customized.                                 }
{          The template tag should satisfy the following pattern:                    }
{          <Templates>                                                               }
{              <HorizontalAppointmentTemplate>                                       }
{                  < ShortNameOfTemplate: NameOfTemplate runat="server"/>            }
{              </HorizontalAppointmentTemplate>                                      }
{          </Templates>                                                              }
{          where ShortNameOfTemplate, NameOfTemplate are the names of the            }
{          registered templates, defined in step 2.                                  }
{************************************************************************************}
*/

using System;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Drawing;

public partial class HorizontalAppointmentTemplate : System.Web.UI.UserControl {
	HorizontalAppointmentTemplateContainer Container { get { return (HorizontalAppointmentTemplateContainer)Parent; } }
	HorizontalAppointmentTemplateItems Items { get { return Container.Items; } }

	protected void Page_Load(object sender, EventArgs e) {
		appointmentDiv.Style.Value = Items.AppointmentStyle.GetStyleAttributes(Page).Value;

		lblTitle.ControlStyle.MergeWith(Items.Title.Style);
		lblStartContinueText.ControlStyle.MergeWith(Items.StartContinueText.Style);
		lblEndContinueText.ControlStyle.MergeWith(Items.EndContinueText.Style);

		LayoutAppointmentImages();

		statusContainer.Controls.Add(Items.StatusControl);
		startTimeClockContainer.Controls.Add(Items.StartTimeClock);
		endTimeClockContainer.Controls.Add(Items.EndTimeClock);
	}
	void LayoutAppointmentImages() {		
		int count = Items.Images.Count;
		HtmlTableRow row = new HtmlTableRow();
		row.Cells.Add(new HtmlTableCell());
		for (int i = 0; i < count; i++) {
			HtmlTableCell cell = new HtmlTableCell();
			AddImage(cell, Items.Images[i]);
			row.Cells.Add(cell);
		}
		imageContainer.Rows.Add(row);

		Items.StartContinueArrow.ImageProperties.AssignToControl(imgStartContinueArrow, false);
		Items.EndContinueArrow.ImageProperties.AssignToControl(imgEndContinueArrow, false);
	}
	void AddImage(HtmlTableCell targetCell, AppointmentImageItem imageItem) {
		Image image = new Image();
		imageItem.ImageProperties.AssignToControl(image, false);
		targetCell.Controls.Add(image);
	}

}
