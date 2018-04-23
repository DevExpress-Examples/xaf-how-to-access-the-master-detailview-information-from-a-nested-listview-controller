'
'{************************************************************************************}
'{                                                                                    }
'{   DO NOT MODIFY THIS FILE!                                                         }
'{                                                                                    }
'{   It will be overwritten without prompting when a new version becomes              }
'{   available. All your changes will be lost.                                        }
'{                                                                                    }
'{   This file contains the default template and is required for the appointment      }
'{   rendering. Improper modifications may result in incorrect appearance of the      }
'{   appointment.                                                                     }
'{                                                                                    }
'{   In order to create and use your own custom template, perform the following       }
'{   steps:                                                                           }
'{       1. Save a copy of this file with a different name in another location.       }
'{       2. Add a Register tag in the .aspx page header for each template you use,    }
'{          as follows: <%@ Register Src="PathToTemplateFile" TagName="NameOfTemplate"}
'{          TagPrefix="ShortNameOfTemplate" %>                                        }
'{       3. In the .aspx page find the tags for different scheduler views within      }
'{          the ASPxScheduler control tag. Insert template tags into the tags         }
'{          for the views which should be customized.                                 }
'{          The template tag should satisfy the following pattern:                    }
'{          <Templates>                                                               }
'{              <HorizontalSameDayAppointmentTemplate>                                }
'{                  < ShortNameOfTemplate: NameOfTemplate runat="server"/>            }
'{              </HorizontalSameDayAppointmentTemplate>                               }
'{          </Templates>                                                              }
'{          where ShortNameOfTemplate, NameOfTemplate are the names of the            }
'{          registered templates, defined in step 2.                                  }
'{************************************************************************************}
' 


Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Drawing

Partial Public Class HorizontalSameDayAppointmentTemplate
	Inherits System.Web.UI.UserControl
	Private ReadOnly Property Container() As HorizontalAppointmentTemplateContainer
		Get
			Return CType(Parent, HorizontalAppointmentTemplateContainer)
		End Get
	End Property
	Private ReadOnly Property Items() As HorizontalAppointmentTemplateItems
		Get
			Return Container.Items
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		appointmentDiv.Style.Value = Items.AppointmentStyle.GetStyleAttributes(Page).Value

		lblStartTime.ControlStyle.MergeWith(Items.StartTimeText.Style)
		lblEndTime.ControlStyle.MergeWith(Items.EndTimeText.Style)
		lblTitle.ControlStyle.MergeWith(Items.Title.Style)

		LayoutAppointmentImages()

		statusContainer.Controls.Add(Container.Items.StatusControl)
		startTimeClockContainer.Controls.Add(Container.Items.StartTimeClock)
		endTimeClockContainer.Controls.Add(Container.Items.EndTimeClock)
	End Sub
	Private Sub LayoutAppointmentImages()
		Dim count As Integer = Items.Images.Count
		Dim row As New HtmlTableRow()
		row.Cells.Add(New HtmlTableCell())
		For i As Integer = 0 To count - 1
			Dim cell As New HtmlTableCell()
			AddImage(cell, Items.Images(i))
			row.Cells.Add(cell)
		Next i
		imageContainer.Rows.Add(row)
	End Sub
	Private Sub AddImage(ByVal targetCell As HtmlTableCell, ByVal imageItem As AppointmentImageItem)
		Dim image As New Image()
		imageItem.ImageProperties.AssignToControl(image, False)
		targetCell.Controls.Add(image)
	End Sub

End Class
