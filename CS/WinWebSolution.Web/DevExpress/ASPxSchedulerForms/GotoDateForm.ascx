<%--
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
{       2. Specify the file location as the 'OptionsForms.GotoDateFormTemplateUrl'   }
{          property of the ASPxScheduler control.                                    }
{       3. If you need to display and process additional controls, you               }
{          should accomplish steps 4-6; otherwise, go to step 7.                     }
{       4. Create a class, derived from the GotoDateFormTemplateContainer,           }
{          containing additional properties which correspond to your controls.       }
{          This class definition can be located within a class file in the App_Code  }
{          folder.                                                                   }
{       5. Replace GotoDateFormTemplateContainer references in the template page     }
{          with the name of the class you've created in step 4.                      }
{       6. Handle the GotoDateFormShowing event to create an instance of the         }
{          template container class, defined in step 5, and specify it as the        }
{          destination container  instead of the  default one.                       }
{       7. Modify the overall appearance of the page and its layout.                 }
{                                                                                    }
{************************************************************************************}
--%>

<%@ Control Language="C#" AutoEventWireup="true" Inherits="GotoDateForm" Codebehind="GotoDateForm.ascx.cs" %>
<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v11.2" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>
    
<table style="width:100%; height:100%">
    <tr>
        <td>
            <dxe:ASPxLabel ID="lblDate" runat="server" Text="Date:" />
        </td>
        <td style="width:100%">
            <dxe:ASPxDateEdit ClientInstanceName="_dx" ID="edtDate" runat="server" Width="100%" Date='<%#((GotoDateFormTemplateContainer)Container).Date %>' />
        </td> 
    </tr>
    <tr>
        <td>
            <span style="white-space: nowrap;">
            <dxe:ASPxLabel ID="lblView" runat="server" Text="Show in:"></dxe:ASPxLabel>
            </span>
        </td>
        <td style="width:100%">
            <dxe:ASPxComboBox ClientInstanceName="_dx" ID="cbView" runat="server" Width="100%" DataSource='<%#((GotoDateFormTemplateContainer)Container).ViewsDataSource %>'></dxe:ASPxComboBox>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2" style="width:100%">
            <table>
                <tr>
                    <td>
                        <dxe:ASPxButton ID="btnOk" ClientInstanceName="_dx" runat="server" Text="OK" UseSubmitBehavior="false" AutoPostBack="false" EnableViewState="false" Width="91px" />
                    </td>
                    <td>
                        <dxe:ASPxButton ID="btnCancel" ClientInstanceName="_dx" runat="server" Text="Cancel" UseSubmitBehavior="false" AutoPostBack="false" EnableViewState="false" 
                            Width="91px" CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>    


