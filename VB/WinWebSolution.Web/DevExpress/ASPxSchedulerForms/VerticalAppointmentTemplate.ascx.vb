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
'{              <VerticalAppointmentTemplate>                                         }
'{                  < ShortNameOfTemplate: NameOfTemplate runat="server"/>            }
'{              </VerticalAppointmentTemplate>                                        }
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

Partial Public Class VerticalAppointmentTemplate
	Inherits System.Web.UI.UserControl
	Private ReadOnly Property Container() As VerticalAppointmentTemplateContainer
		Get
			Return CType(Parent, VerticalAppointmentTemplateContainer)
		End Get
	End Property
	Private ReadOnly Property Items() As VerticalAppointmentTemplateItems
		Get
			Return Container.Items
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		appointmentDiv.Style.Value = Items.AppointmentStyle.GetStyleAttributes(Page).Value
		horizontalSeparator.Style.Value = Items.HorizontalSeparator.Style.GetStyleAttributes(Page).Value

		lblStartTime.ControlStyle.MergeWith(Items.StartTimeText.Style)
		lblEndTime.ControlStyle.MergeWith(Items.EndTimeText.Style)
		lblTitle.ControlStyle.MergeWith(Items.Title.Style)
		lblDescription.ControlStyle.MergeWith(Items.Description.Style)

		statusContainer.Controls.Add(Items.StatusControl)
		LayoutAppointmentImages()
	End Sub
	Private Sub LayoutAppointmentImages()
		Dim count As Integer = Items.Images.Count
		For i As Integer = 0 To count - 1
			Dim row As New HtmlTableRow()
			Dim cell As New HtmlTableCell()
			AddImage(cell, Items.Images(i))
			row.Cells.Add(cell)
			imageContainer.Rows.Add(row)
		Next i
	End Sub
	Private Sub AddImage(ByVal targetCell As HtmlTableCell, ByVal imageItem As AppointmentImageItem)
		Dim image As New Image()
		imageItem.ImageProperties.AssignToControl(image, False)
		targetCell.Controls.Add(image)
	End Sub
End Class