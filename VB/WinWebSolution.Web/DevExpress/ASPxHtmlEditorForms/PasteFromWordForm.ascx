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
{   dialog forms.                                                                    }
{                                                                                    }
{************************************************************************************}
--%>
<%@ Control Language="vb" AutoEventWireup="true" Codebehind="PasteFromWordForm.ascx.vb" Inherits="PasteFromWordForm" %>
<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v13.1" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dxhe" %>
<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>

<%-- B141214 --%>
<dxe:ASPxLabel ID="lblB141214" runat="server" Style="display: none;" />

<dxp:ASPxPanel ID="MainPanel" runat="server" Width="100%" DefaultButton="btnOk" RenderMode="Table">
    <PanelCollection>
        <dxp:PanelContent ID="PanelContent1" runat="server">
            <table cellpadding="0" cellspacing="0" id="dxPasteFromWordForm">
                <tr>
                    <td class="contentCell">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <dxe:ASPxLabel ID="lblDescription" runat="server">
                                    </dxe:ASPxLabel>
                                </td>
                            </tr>
                            <tr>
                                <td class="pasteContainerCell">
                                    <table cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <iframe id='<% =HtmlEditor.ClientID + "_dxePasteFromWordContainer"%>' class="pasteContainer">
                                                </iframe>                                            
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="checkBoxCell">
                                    <dxe:ASPxCheckBox ID="ckbStripFont" runat="server" ClientInstanceName="_dxeCkbStripFont">
                                    </dxe:ASPxCheckBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="buttonsCell" align="right">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <dxe:ASPxButton ID="btnOk" runat="server" AutoPostBack="False" Height="23px"
                                        Width="74px" ClientInstanceName="_dxeBtnOk" CausesValidation="False" >
                                        <clientsideevents click="function(s, e) {OnOkButtonClick_PasteFromWordForm();}" />
                                    </dxe:ASPxButton>
                                </td>
                                <td class="cancelButton">
                                    <dxe:ASPxButton ID="btnCancel" runat="server" AutoPostBack="False"
                                        Height="23px" Width="74px" CausesValidation="False" >
                                        <clientsideevents click="function(s, e) {OnCancelButtonClick_PasteFromWordForm();}" />
                                    </dxe:ASPxButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>        
        </dxp:PanelContent>
    </PanelCollection>
</dxp:ASPxPanel>
<script type="text/javascript" id="dxss_PasteFromWordForm">
    function OnOkButtonClick_PasteFromWordForm() {
        var res = {
            html: _aspxIFrameDocumentBody('<% =HtmlEditor.ClientID + "_dxePasteFromWordContainer"%>').innerHTML,
            stripFontFamily: _dxeCkbStripFont.GetChecked()
        };
        aspxDialogComplete(1, res);
    }
    function OnCancelButtonClick_PasteFromWordForm() {
        aspxDialogComplete(0, null);
    }
</script>