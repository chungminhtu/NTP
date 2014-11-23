<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Settings.ascx.vb" Inherits="DotNetNuke.Modules.Chat.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<table id="tblSettings" runat="server" cellspacing="0" cellpadding="2" border="0"
    summary="Chat Settings Design Table" style="width: 100%">
            <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblPollingInterval" runat="server" ControlName="txtPollingInterval" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtPollingInterval" CssClass="NormalTextBox" runat="server" Columns="5"/>
                        <asp:CompareValidator ID="valPollingInterval" runat="server" ResourceKey="valPollingInterval.ErrorMessage"
                Type="Integer" Operator="DataTypeCheck" ControlToValidate="txtPollingInterval" CssClass="NormalRed" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblHistoryCapacity" runat="server" ControlName="txtHistoryCapacity" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtHistoryCapacity" CssClass="NormalTextBox" runat="server" Columns="5" />
            <asp:CompareValidator ID="valHistoryCapacity" runat="server" ResourceKey="valHistoryCapacity.ErrorMessage"
                Type="Integer" Operator="DataTypeCheck" ControlToValidate="txtHistoryCapacity" CssClass="NormalRed" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblDisplayCapacity" runat="server" ControlName="txtDisplayCapacity" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtDisplayCapacity" CssClass="NormalTextBox" runat="server" Columns="5" />
            <asp:CompareValidator ID="valDisplayCapacity" runat="server" ResourceKey="valDisplayCapacity.ErrorMessage"
                Type="Integer" Operator="DataTypeCheck" ControlToValidate="txtDisplayCapacity" CssClass="NormalRed" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblAllowFormatting" runat="server" ControlName="chkAllowFormatting" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:CheckBox ID="chkAllowFormatting" CssClass="NormalTextBox" runat="server" Columns="5" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblHeight" runat="server" ControlName="txtHeight" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtHeight" CssClass="NormalTextBox" runat="server" Columns="10" />
        </td>
    </tr>
        <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblSenderText" runat="server" ControlName="txtSenderText" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtSenderText" CssClass="NormalTextBox" runat="server" Width="100%" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblEnteredMessage" runat="server" ControlName="txtEnteredMessage" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtEnteredMessage" CssClass="NormalTextBox" runat="server" Width="100%" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblExitedMessage" runat="server" ControlName="txtExitedMessage" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtExitedMessage" CssClass="NormalTextBox" runat="server" Width="100%" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblMessageCssClass" runat="server" ControlName="txtMessageCssClass" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtMessageCssClass" CssClass="NormalTextBox" runat="server" Width="100%" />
        </td>
    </tr>
    <tr>
        <td class="SubHead" style="vertical-align: top">
            <dnn:Label ID="lblSenderCssClass" runat="server" ControlName="txtSenderCssClass" Suffix=":">
            </dnn:Label>
        </td>
        <td style="vertical-align: top">
            <asp:TextBox ID="txtSenderCssClass" CssClass="NormalTextBox" runat="server" Width="100%" />
        </td>
    </tr>

    
</table>
