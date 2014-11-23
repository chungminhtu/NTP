<%@ Control language="vb" Inherits="YourCompany.Modules.NTP_BN_DM_KETQUADT.EditNTP_BN_DM_KETQUADT" CodeFile="EditNTP_BN_DM_KETQUADT.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>


    <table class="ntp_table_main" width="100%">
        <tr>
            <td style="height: 26px" width="20%">
                <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Tên kết quả điều trị"></asp:Label></td>
            <td colspan="2" style="height: 26px" width="80%">
                <asp:TextBox ID="txtKetQuaDT" runat="server" CssClass="ntp_textbox" MaxLength="250"
                    TabIndex="1" Width="500px"></asp:TextBox>
                <asp:TextBox ID="txtID_KetQuaDT" runat="server" CssClass="ntp_textbox" Visible="False"
                    Width="72px"></asp:TextBox></td>
        </tr>
        <tr>
            <td width="20%">
            </td>
            <td colspan="2" width="80%">
                <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" TabIndex="3" Text="Ghi lại"
                    Width="100px" />&nbsp;
                <asp:Button ID="Button1" runat="server" CausesValidation="False" CssClass="ntp_button"
                    Text="Thoát" Width="100px" /></td>
        </tr>
        <tr>
            <td colspan="3" style="height: 21px" width="20%">
            </td>
        </tr>
    </table>


