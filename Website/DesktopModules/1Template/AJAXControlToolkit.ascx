<%@ Control Language="VB" AutoEventWireup="false" CodeFile="AJAXControlToolkit.ascx.vb"
    Inherits="DotNetNuke.Modules.AJAXControlToolkit.AJAXControlToolkit" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<style>
.PanelExtender
{
    position: relative;
}
</style>
<br />
<table>
    <tr>
        <td nowrap="noWrap" valign="top">
            <strong>
                <asp:Panel ID="pnlUsers" runat="server" Height="50px" Width="125px" CssClass="PanelExtender">
                    Enter User:
                    <asp:TextBox ID="MessageTextBox" runat="server" Width="200" autocomplete="off" />
                    <asp:Button ID="btnUser" runat="server" Text="Select User" />
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged"
                                Style="border: 1px outset white; width: 200px" BackColor="white">
                                <asp:ListItem Text="Shaun Walker" />
                                <asp:ListItem Text="Joe Brinkman" />
                                <asp:ListItem Text="Nik Kalyani" />
                                <asp:ListItem Text="Scott Willhite" />
                                <asp:ListItem Text="Cancel" Value="" />
                            </asp:RadioButtonList>&nbsp;
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <ajaxToolkit:PopupControlExtender ID="PopupControlExtender2" runat="server" TargetControlID="MessageTextBox"
                        PopupControlID="UpdatePanel2" CommitProperty="value" Position="Bottom" CommitScript="e.value;" />
                </asp:Panel>
                <br />
            </strong>&nbsp;
        </td>
        <td nowrap="noWrap" valign="top">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <strong>&nbsp; Selected:</strong>
                    <asp:Label ID="lblSelectedUser" runat="server"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnUser" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
