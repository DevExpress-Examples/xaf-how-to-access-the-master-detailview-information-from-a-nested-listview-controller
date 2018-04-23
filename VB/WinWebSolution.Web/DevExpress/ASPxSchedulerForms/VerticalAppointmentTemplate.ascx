<%--
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
{              <VerticalAppointmentTemplate>                                         }
{                  < ShortNameOfTemplate: NameOfTemplate runat="server"/>            }
{              </VerticalAppointmentTemplate>                                        }
{          </Templates>                                                              }
{          where ShortNameOfTemplate, NameOfTemplate are the names of the            }
{          registered templates, defined in step 2.                                  }
{************************************************************************************}
--%>
<%@ Control Language="vb" AutoEventWireup="true" Inherits="VerticalAppointmentTemplate" Codebehind="VerticalAppointmentTemplate.ascx.vb" %>
<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v12.2" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register Assembly="DevExpress.Web.v12.2" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<div id="appointmentDiv" runat="server" class='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.AppointmentStyle.CssClass%>'>
	<table width="100%" cellpadding="0" cellspacing="0">
		<tr valign="top" >
			<td runat="server" id="statusContainer">    
			</td>
			<td style="width:100%">
				<table cellpadding="1" cellspacing="0" width="100%">
					<tr valign="top">
						<td>
							<table id="imageContainer" runat="server" cellpadding="1" cellspacing="0" style="text-align: center">
								<tr><td></td></tr>
							</table>
						</td>
						<td style="width:100%">                    
							<table width="100%" cellpadding="1" cellspacing="0" >                        
								<tr>
									<td>
										<dxe:ASPxLabel runat="server" EnableViewState="false" EncodeHtml="true" ID="lblStartTime" Text='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.StartTimeText.Text%>' Visible='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.StartTimeText.Visible%>'></dxe:ASPxLabel>
										<dxe:ASPxLabel runat="server" EnableViewState="false" EncodeHtml="true" style="margin-left: -4px;" ID="lblEndTime" Text='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.EndTimeText.Text%>' Visible='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.EndTimeText.Visible%>'></dxe:ASPxLabel>        
										<dxe:ASPxLabel runat="server" EnableViewState="false" EncodeHtml="true" ID="lblTitle" Text='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.Title.Text%>'></dxe:ASPxLabel>
									</td>
								</tr>
								<tr>
									<td>
										<div runat="server" id="horizontalSeparator" class='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.HorizontalSeparator.Style.CssClass%>' visible='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.HorizontalSeparator.Visible%>'></div>
									</td>
								</tr>
								<tr>
									<td>
										<dxe:ASPxLabel runat="server" EnableViewState="false" EncodeHtml="true" ID="lblDescription" Text='<%#(CType(Container, VerticalAppointmentTemplateContainer)).Items.Description.Text%>'></dxe:ASPxLabel>
									</td>        
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</div>