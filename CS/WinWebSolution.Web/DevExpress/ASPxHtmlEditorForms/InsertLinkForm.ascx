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
<%@ Control Language="C#" AutoEventWireup="true" Codebehind="InsertLinkForm.ascx.cs" Inherits="InsertLinkFrom" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v11.2" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dxhe" %>
<%@ Register Assembly="DevExpress.Web.v11.2" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<dxp:ASPxPanel ID="MainPanel" runat="server" Width="100%" DefaultButton="btnOk">
    <PanelCollection>
        <dxp:PanelContent runat="server">
    <table cellpadding="0" cellspacing="0" id="dxInsertLinkForm">
        <tr>
            <td class="contentCell">
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="typeRadionButtonListCell">
                            <dxe:ASPxRadioButtonList ID="rblLinkType" runat="server" ItemSpacing="22px" RepeatDirection="Horizontal"
                                SelectedIndex="0" ClientInstanceName="_dxeRblLinkType">
                                <clientsideevents selectedindexchanged="function(s, e) { OnTypeLinkChanged__InsertLinkForm(s); }" />
                                <border borderstyle="None" />
                                <paddings paddingleft="0px" paddingtop="0px" paddingbottom="0px" />
                            </dxe:ASPxRadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dxhe:ASPxHtmlEditorRoundPanel ID="rpInsertLink" runat="server">
                                <panelcollection>
                                    <dxhe:HtmlEditorRoundPanelContent runat="server">
                                        <!-- URL -->                                        
                                        <table cellpadding="0" cellspacing="0" id='<% =HtmlEditor.ClientID + "_dxeURLArea" %>'>
                                            <tr>
                                                <td class="captionCell">                        
                                                    <dxe:ASPxLabel ID="lblUrl" runat="server" AssociatedControlID="txbURL">
                                                    </dxe:ASPxLabel>                                
                                                </td>
                                                <td class="inputCell">                        
                                                    <dxe:ASPxTextBox ID="txbURL" ClientInstanceName="_dxeTxbURL" runat="server" Width="274px" AutoCompleteType="Disabled">
                                                        <ValidationSettings ErrorDisplayMode="Text" ErrorTextPosition="Bottom" SetFocusOnError="True" ValidateOnLeave="False" ValidationGroup="_dxeTxbURLGroup">
                                                            <RequiredField IsRequired="True" />
                                                            <ErrorFrameStyle Font-Size="10px">
                                                            </ErrorFrameStyle>
                                                        </ValidationSettings>
                                                    </dxe:ASPxTextBox>                                
                                                </td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" id='<% =HtmlEditor.ClientID + "_dxeEmailArea" %>' style="display: none;">
                                            <tr>
                                                <td class="captionCell">                        
                                                    <dxe:ASPxLabel ID="lblEmailTo" runat="server" AssociatedControlID="txbEmailTo">
                                                    </dxe:ASPxLabel>                                
                                                </td>
                                                <td class="inputCell">                        
                                                    <dxe:ASPxTextBox ID="txbEmailTo" ClientInstanceName="_dxeTxbEmailTo" runat="server" Width="250px" AutoCompleteType="Disabled">
                                                        <ValidationSettings ErrorDisplayMode="Text" ErrorTextPosition="Bottom" SetFocusOnError="True" ValidateOnLeave="False" ValidationGroup="_dxeTxbEmailToGroup">
                                                            <RegularExpression ErrorText="Invalid e-mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                            <ErrorFrameStyle Font-Size="10px">
                                                            </ErrorFrameStyle>
                                                            <RequiredField IsRequired="True" />
                                                        </ValidationSettings>
                                                    </dxe:ASPxTextBox>
                                                </td>                        
                                            </tr>
                                            <tr>
                                                <td class="captionCell">                        
                                                    <dxe:ASPxLabel ID="lblSubject" runat="server" AssociatedControlID="txbSubject">
                                                    </dxe:ASPxLabel>                                
                                                </td>
                                                <td class="inputCell">                        
                                                    <dxe:ASPxTextBox ID="txbSubject" ClientInstanceName="_dxeTxbSubject" runat="server" Width="250px" AutoCompleteType="Disabled">
                                                    </dxe:ASPxTextBox>                                
                                                </td>                        
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td colspan="2" class="displayPropertiesCell">
                                                    <dxe:ASPxLabel ID="lblLinkDisplay" runat="server">
                                                    </dxe:ASPxLabel>                                                            
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="captionCell">                        
                                                    <dxe:ASPxLabel ID="lblText" ClientInstanceName="_dxeLblText" runat="server" AssociatedControlID="txbText">
                                                    </dxe:ASPxLabel>
                                                </td>
                                                <td class="inputCell">                        
                                                    <dxe:ASPxTextBox ID="txbText" ClientInstanceName="_dxeTxbText" runat="server" Width="258px" AutoCompleteType="Disabled">
                                                    </dxe:ASPxTextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" class="separatorCell"></td>
                                            </tr>
                                            <tr>
                                                <td class="captionCell">                        
                                                    <dxe:ASPxLabel ID="lblToolTip" runat="server" AssociatedControlID="txbToolTip">
                                                    </dxe:ASPxLabel>
                                                </td>
                                                <td class="inputCell">
                                                    <dxe:ASPxTextBox ID="txbToolTip" ClientInstanceName="_dxeTxbToolTip" runat="server" Width="258px" AutoCompleteType="Disabled">
                                                    </dxe:ASPxTextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </dxhe:HtmlEditorRoundPanelContent>
                                </panelcollection>
                            </dxhe:ASPxHtmlEditorRoundPanel>
                        </td>
                    </tr>
                    <tr>
                        <td id='<% =HtmlEditor.ClientID + "_dxeTargetArea" %>' class="targetCheckBoxCell">
                            <dxe:ASPxCheckBox ID="ckbOpenInNewWindow" ClientInstanceName="_dxeCkbOpenInNewWindow" runat="server"></dxe:ASPxCheckBox>
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
                                <clientsideevents click="function(s, e) {OnOkButtonClick_InsertLinkForm();}" />
                            </dxe:ASPxButton>
                            <dxe:ASPxButton ID="btnChange" runat="server" AutoPostBack="False"
                                Height="23px" Width="74px" ClientInstanceName="_dxeBtnChange" ClientVisible="False" CausesValidation="False" >
                                <clientsideevents click="function(s, e) { OnOkButtonClick_InsertLinkForm(); }" />
                            </dxe:ASPxButton>
                        </td>
                        <td class="cancelButton">
                            <dxe:ASPxButton ID="btnCancel" runat="server" AutoPostBack="False"
                                Height="23px" Width="74px" CausesValidation="False" >
                                <clientsideevents click="function(s, e) {OnCancelButtonClick_InsertLinkForm();}" />
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
<script type="text/javascript" id="dxss_InsertLinkForm">
    function OnOkButtonClick_InsertLinkForm() {
        if (IsValidFields_InsertLinkForm())
            aspxDialogComplete(1, GetDialogData_InsertLinkForm());
    }
    function OnCancelButtonClick_InsertLinkForm() {
        aspxDialogComplete(0, GetDialogData_InsertLinkForm());
    }
    
    function OnTypeLinkChanged__InsertLinkForm(radioButtonList) {
        var value = radioButtonList.GetValue();
        var urlArea = _aspxGetElementById('<% =HtmlEditor.ClientID + "_dxeURLArea" %>');
        var emailArea = _aspxGetElementById('<% =HtmlEditor.ClientID + "_dxeEmailArea" %>');
        var targetArea = _aspxGetElementById('<% =HtmlEditor.ClientID + "_dxeTargetArea" %>');
                
        _aspxSetElementDisplay(urlArea, value == "URL");
        _aspxSetElementDisplay(targetArea, value == "URL");
        
        _aspxSetElementDisplay(emailArea, value == "Email");        
    }
    function IsValidFields_InsertLinkForm() {
        var ret = true;
        if (_dxeTxbEmailTo.IsVisible())
            ret = ASPxClientEdit.ValidateGroup("_dxeTxbEmailToGroup") && ret;
        if (_dxeTxbURL.IsVisible())
            ret = ASPxClientEdit.ValidateGroup("_dxeTxbURLGroup") && ret;
        return ret;
    }
    function GetDialogData_InsertLinkForm() {
        var res = new Object();        
        res.subject = "";
        res.target = "";
        res.text = "";
        res.title = "";
        res.url = "";
        res.isCheckedOpenInNewWindow = false;
        
        res.isCheckedOpenInNewWindow = _dxeCkbOpenInNewWindow.GetValue();
        res.isTextOnlySelected = _dxeTxbText.GetEnabled();
        res.url = _dxeRblLinkType.GetValue() == "Email" ? _dxeTxbEmailTo.GetValue() : _dxeTxbURL.GetValue();
        res.subject = _dxeTxbSubject.GetValue();
        res.text = _dxeTxbText.GetText();
        res.title = _dxeTxbToolTip.GetText();
        
        return res;
    }
</script>