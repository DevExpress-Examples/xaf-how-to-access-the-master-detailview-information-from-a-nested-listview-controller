<%@ Control Language="vb" AutoEventWireup="true" Inherits="ReminderForm" Codebehind="ReminderForm.ascx.vb" %>
<%@ Register Assembly="DevExpress.Web.v12.2" Namespace="DevExpress.Web.ASPxEditors"
	TagPrefix="dxe" %>

<table width="100%" cellpadding="0" cellspacing="0" style="padding-bottom:15px;">
	<tr><td> 
		 <dxe:ASPxListBox ID="lbItems" runat="server" Width="100%" style="padding-bottom:15px;"></dxe:ASPxListBox>
	</td></tr>
</table>
<table width="100%" cellpadding="0" cellspacing="0">
	<tr>
		<td style="width:100%;"><dxe:ASPxButton ID="btnDismissAll" runat="server" Text="Dismiss All" AutoPostBack="false"></dxe:ASPxButton></td>
		<td style="width:80px;" align="right"><dxe:ASPxButton ID="btnDismiss" runat="server" Text="Dismiss" Width="80px" AutoPostBack="false"></dxe:ASPxButton></td>
	</tr>
	<tr>
		<td colspan="2" style="padding:8px 0 4px 0;"><dxe:ASPxLabel ID="lblClickSnooze" runat="server" Text="Click Snooze to be reminded again in:"></dxe:ASPxLabel></td>
	</tr>
	<tr>
		<td style="width:100%;padding-right:20px;"><dxe:ASPxComboBox ID="cbSnooze" runat="server" Width="100%">
		</dxe:ASPxComboBox></td>
		<td style="width:80px;"><dxe:ASPxButton ID="btnSnooze" runat="server" Text="Snooze" Width="80px" AutoPostBack="false"></dxe:ASPxButton></td>
	</tr>
</table>