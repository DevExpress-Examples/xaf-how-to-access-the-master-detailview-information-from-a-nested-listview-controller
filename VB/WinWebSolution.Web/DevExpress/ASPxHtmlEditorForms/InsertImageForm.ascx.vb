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
Imports System.IO
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

Partial Public Class InsertImageForm
	Inherits HtmlEditorUserControl

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ckbSaveToServer.ClientVisible = HtmlEditor.Settings.AllowInsertDirectImageUrls AndAlso Not String.IsNullOrEmpty(HtmlEditor.SettingsImageUpload.UploadImageFolder)
		rblFromThisComputer.ClientEnabled = Not String.IsNullOrEmpty(HtmlEditor.SettingsImageUpload.UploadImageFolder)
		Localize()
	End Sub
	Private Sub Localize()
		rblFromTheWeb.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_FromWeb)
		rblFromThisComputer.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_FromLocal)
		lblImageUrl.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_EnterUrl) & ":"
		txbInsertImageUrl.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError)
		ckbSaveToServer.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_SaveToServer)
		lblBrowse.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_UploadInstructions) & ":"
		ckbMoreImageOptions.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertImage_MoreOptions)
		btnInsertImage.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonInsert)
		btnChangeImage.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonChange)
		btnInsertImageCancel.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonCancel)
	End Sub
	Protected Overrides Function GetChildDxEdits() As ASPxEditBase()
		Return New ASPxEditBase() { rblFromTheWeb, rblFromThisComputer, txbInsertImageUrl, ckbSaveToServer, ckbMoreImageOptions }
	End Function
	Protected Overrides Function GetChildDxButtons() As ASPxButton()
		Return New ASPxButton() { btnInsertImage, btnChangeImage, btnInsertImage, btnInsertImageCancel }
	End Function
	Protected Overrides Function GetChildDxHtmlEditorRoundPanel() As ASPxHtmlEditorRoundPanel
		Return rpInsertImage
	End Function

	Protected Function SaveUploadFile() As String
		Dim fileName As String = ""
		If (Not String.IsNullOrEmpty(uplImage.UploadedFiles(0).FileName)) Then
			Dim uploadFolder As String = HtmlEditor.SettingsImageUpload.UploadImageFolder
			fileName = MapPath(uploadFolder) + uplImage.UploadedFiles(0).FileName
			Try
				uplImage.UploadedFiles(0).SaveAs(fileName, False)
			Catch e1 As IOException
				fileName = MapPath(uploadFolder) + uplImage.GetRandomFileName()
				uplImage.UploadedFiles(0).SaveAs(fileName)
			End Try
		End If
		Return Path.GetFileName(fileName)
	End Function
	Protected Sub uplImage_FileUploadComplete(ByVal sender As Object, ByVal args As DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs)
		Try
			args.CallbackData = SaveUploadFile()
		Catch e As Exception
			args.IsValid = False
			args.ErrorText = e.Message
		End Try
	End Sub
End Class