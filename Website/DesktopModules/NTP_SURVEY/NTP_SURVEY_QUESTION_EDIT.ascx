<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_SURVEY_QUESTION_EDIT.ascx.vb" Inherits="NTP_SURVEY_QUESTION_EDIT" %>
<%@ Register Assembly="MetaBuilders.WebControls.ConfirmedButtons" Namespace="MetaBuilders.WebControls"
    TagPrefix="mbcb" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc4" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl.ASB" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Panel ID="pnlHeader" runat="server" Width="100%">
<fieldset class="ntp_fieldset">
<legend class="ntp_legend">Thông tin câu hỏi</legend>
<table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%">
            <asp:Label ID="Label21" runat="server" CssClass="ntp_label">Nội dung câu hỏi</asp:Label>
            <asp:Label ID="Label2" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="3" style="width: 30%">
            <asp:TextBox ID="txtGhiChu" runat="server" CssClass="ntp_textbox" MaxLength="250"
                TabIndex="7" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
    </tr>
    <tr>
        <td width="20%">
            <asp:Label ID="Label1" runat="server" CssClass="ntp_label" Text="Thứ tự câu trả lời"></asp:Label>
            <asp:Label ID="Label9" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td style="width: 30%">
            <asp:TextBox ID="txtVIEW_ORDER" runat="server" CssClass="ntp_textbox" Width="50%" TabIndex="1" MaxLength="50"></asp:TextBox>
            <asp:TextBox ID="txtSURVEY_ID" runat="server" CssClass="ntp_textbox"
                Width="64px" MaxLength="10" TabIndex="1" Visible="False"></asp:TextBox>&nbsp;
        </td>
        <td  width="20%">
            <asp:Label ID="Label5" runat="server" CssClass="ntp_label">Kiểu câu trả lời</asp:Label>
            <asp:Label ID="Label14" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
         <td width="30%">
             <asp:DropDownList ID="cboQUESTION_TYPE" runat="server" CssClass="ntp_combobox" Width="100%" TabIndex="4">
                 <asp:ListItem Value="1">Chọn một đ&#225;p &#225;n</asp:ListItem>
                 <asp:ListItem Value="2">Chọn nhiều đ&#225;p &#225;n</asp:ListItem>
        </asp:DropDownList></td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="3" style="width: 30%">
        </td>
    </tr>
    <tr>
        <td width ="20%">
            </td>
        <td style="width: 30%" colspan="3">
            <asp:Button ID="cmdAdd" runat="server" CssClass="ntp_button" Text="Ghi câu hỏi" Width="100px" TabIndex="8" />&nbsp;
            <asp:Button ID="cmdCancel" runat="server" CssClass="ntp_button" Text="Thoát" Width="100px" CausesValidation="False" />&nbsp;
            <asp:Button ID="cmdCreateNew" runat="server" CssClass="ntp_button" Text="Tạo câu hỏi mới" Width="136px" TabIndex="8" /></td>
    </tr>
</table>
</fieldset>

</asp:Panel>
<asp:Panel ID="pnlDetail" runat="server" Width="100%" DefaultButton="cmdSave">
<fieldset class="ntp_fieldset">
    <legend class="ntp_legend">Thông tin câu trả lời&nbsp;</legend>
    <table width="100%" class = "ntp_table_main">
    <tr>
        <td width="20%" style="height: 26px">
            <asp:Label ID="Label3" runat="server" CssClass="ntp_label" Text="Nội dung câu trả lời"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="ntp_require" Text="*"></asp:Label></td>
        <td colspan="2" width="80%" style="height: 26px">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="ntp_textbox" MaxLength="250"
                TabIndex="7" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
    </tr>
        <tr>
            <td style="height: 26px" width="20%">
                <asp:Label ID="Label17" runat="server" CssClass="ntp_label" Text="Thứ tự câu trả lời"></asp:Label></td>
            <td colspan="2" style="height: 26px" width="80%">
                <asp:TextBox ID="txtLO_SANXUAT" runat="server" CssClass="ntp_textbox" MaxLength="50" TabIndex="11"
                    Width="72px"></asp:TextBox>
            <asp:TextBox ID="txtSURVEY_OPTION_ID" runat="server" CssClass="ntp_textbox" MaxLength="10"
                TabIndex="1" Visible="False" Width="64px"></asp:TextBox></td>
        </tr>
    <tr>
        <td width="20%" >
        </td>
        <td width="60%" >
        </td>
    </tr>
    <tr>
        <td width="20%">
        </td>
        <td colspan="2" width="80%">
            <asp:Button ID="cmdSave" runat="server" CssClass="ntp_button" Text="Ghi lại" Width="100px" TabIndex="15" />&nbsp;
            <asp:Button ID="cmdDelete" runat="server" CssClass="ntp_button" Text="Xóa câu trả lời" Width="100px" CausesValidation="False" />
            <ajaxToolkit:ConfirmButtonExtender ID="cbe" runat="server"
    TargetControlID="cmdDelete"
    ConfirmText="Bạn thực sự muốn xóa vật tư này trên phiếu?"
     />
            </td>
    </tr>
    <tr>
        <td colspan="3" width="20%">
           <cc4:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
    AutoGenerateColumns="False" CssClass="ntp_grd_GridViewStyle" EditItemStyle-CssClass="ntp_grd_EditRowStyle"
    HeaderStyle-CssClass="ntp_grd_HeaderStyle" HighlightCssClass="ntp_grd_SelectedRowStyle"
    ItemStyle-CssClass="ntp_grd_RowStyle" PagerStyle-CssClass="ntp_grd_PagerStyle"
    SelectedItemStyle-CssClass="ntp_grd_SelectedRowStyle" ShowFooter="True" Width="100%">
    <EditItemStyle CssClass="ntp_grd_EditRowStyle" />
    <SelectedItemStyle CssClass="ntp_grd_SelectedRowStyle" />
    <PagerStyle CssClass="ntp_grd_PagerStyle" Mode="NumericPages" />
    <AlternatingItemStyle CssClass="ntp_grd_AltRowStyle" />
    <ItemStyle CssClass="ntp_grd_RowStyle" />
    <Columns>
        <asp:TemplateColumn>
            <headerstyle width="2%" />
        </asp:TemplateColumn>
        <asp:TemplateColumn>
            <itemtemplate>
<asp:ImageButton id="cmdEdit" runat="server" CausesValidation="False" ImageUrl="~/images/edit.gif" CommandName="edit" __designer:wfdid="w4"></asp:ImageButton> 
</itemtemplate>
            <headerstyle width="2%" />
        </asp:TemplateColumn>
        <asp:BoundColumn DataField="ID_PHIEUNHAP_CHITIET" HeaderText="ID_CHITIET" Visible="False">
        </asp:BoundColumn>
        <asp:BoundColumn DataField="ID_VATTU" HeaderText="ID_VATTU" Visible="False"></asp:BoundColumn>
        <asp:BoundColumn DataField="TEN_VATTU" HeaderText="T&#234;n Vật tư">
            <headerstyle width="40%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="TEN_DVT" HeaderText="Đơn vị t&#237;nh">
            <headerstyle width="10%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="SO_LUONG" HeaderText="Số lượng">
            <headerstyle width="20%" />
        </asp:BoundColumn>
        <asp:BoundColumn DataField="LO_SANXUAT" HeaderText="L&#244; sản xuất">
            <headerstyle width="16%" />
        </asp:BoundColumn>
    </Columns>
    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
</cc4:MultiSelectGrid>
        </td>
    </tr>
</table>
</fieldset>

</asp:Panel>


