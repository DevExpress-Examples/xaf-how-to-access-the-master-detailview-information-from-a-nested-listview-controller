'
'{************************************************************************************}
'{                                                                                    }
'{   DO NOT MODIFY THIS FILE!                                                         }
'{                                                                                    }
'{   It will be overwritten without prompting when a new version becomes              }
'{   available. All your changes will be lost.                                        }
'{                                                                                    }
'{   This file contains the default template and is required for the form             }
'{   rendering. Improper modifications may result in incorrect behavior of            }
'{   dialog forms.                                                                    }
'{                                                                                    }
'{************************************************************************************}
'

Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Web.ASPxHtmlEditor.Localization
Imports DevExpress.Web.ASPxClasses
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxClasses.Internal

Partial Public Class ImagePropertiesForm
	Inherits HtmlEditorUserControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ckbCreateThumbnail.ClientVisible = Not String.IsNullOrEmpty(HtmlEditor.SettingsImageUpload.UploadImageFolder)
		CreateConstrainProportionsImages()
		Localize()
	End Sub
	Private Sub Localize()
		lblSize.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Size) & ":"
		cmbSize.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_OriginalSize), "original")
		cmbSize.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_CustomSize), "custom")
		cmbSize.SelectedIndex = 0
		lblWidth.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Width) & ":"
		lblPixelWidth.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Pixels)
		lblHeight.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Height) & ":"
		lblPixelHeight.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Pixels)
		ckbCreateThumbnail.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_CreateThumbnail)
		lblThumbnailFileName.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_NewImageName) & ":"
		txbThumbnailFileName.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError)
		lblImagePosition.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Position) & ":"
		cmbImagePosition.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_PositionLeft), "left")
		cmbImagePosition.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_PositionCenter), "center")
		cmbImagePosition.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_PositionRight), "right")
		cmbImagePosition.SelectedIndex = 0
		lblImageDescription.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ImageProps_Description) & ":"
		ckbWrapTextArroundImage.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_UseFloat)
	End Sub
	Protected Overrides Function GetChildDxEdits() As ASPxEditBase()
		Return New ASPxEditBase() {lblSize, cmbSize, lblWidth, spnWidth, lblPixelWidth, lblHeight, spnHeight, lblPixelHeight, lblImagePosition, cmbImagePosition, lblImageDescription, txbDescription, ckbCreateThumbnail, lblThumbnailFileName, txbThumbnailFileName, ckbWrapTextArroundImage }
	End Function
	Protected Sub CreateConstrainProportionsImages()
		Dim imgTop As Image = RenderUtils.CreateImage()
		cellContarainTop.Controls.Add(imgTop)
		HtmlEditor.GetInsertImageDialogConstrainProportionsTop().AssignToControl(imgTop, False)

		Dim imgBottom As Image = RenderUtils.CreateImage()
		cellContarainBottom.Controls.Add(imgBottom)
		HtmlEditor.GetInsertImageDialogConstrainProportionsBottom().AssignToControl(imgBottom, False)

		Dim imgSwitcherOn As Image = RenderUtils.CreateImage()
		imgSwitcherOn.ID = "imgOn"
		cellContarainSwitcher.Controls.Add(imgSwitcherOn)
		HtmlEditor.GetInsertImageDialogConstrainProportionsMiddleOn().AssignToControl(imgSwitcherOn, False)

		Dim imgSwitcherOff As Image = RenderUtils.CreateImage()
		imgSwitcherOff.ID = "imgOff"
		cellContarainSwitcher.Controls.Add(imgSwitcherOff)
		HtmlEditor.GetInsertImageDialogConstrainProportionsMiddleOff().AssignToControl(imgSwitcherOff, False)

		imgSwitcherOn.Attributes.Add("onclick", "aspxConstrainProportionsSwitchClick(event, '" & imgSwitcherOff.ClientID & "')")
		imgSwitcherOff.Attributes.Add("onclick", "aspxConstrainProportionsSwitchClick(event,'" & imgSwitcherOn.ClientID & "')")
		imgSwitcherOff.Style.Add("display", "none")
	End Sub
End Class
