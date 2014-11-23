<%@ Control Language="VB" AutoEventWireup="false" CodeFile="NTP_SURVEY_QUESTION_LIST.ascx.vb" Inherits="NTP_SURVEY_EDIT" %>
<%@ Register Assembly="FSE.WebControl" Namespace="FSE.WebControl" TagPrefix="cc3" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
<%@ Register     Assembly="AjaxControlToolkit"     Namespace="AjaxControlToolkit"     TagPrefix="ajaxToolkit" %>
<asp:Panel ID="pnlAll" runat=server Width="100%">
 <table  class = "ntp_table_main" width="100%">
     <tr>
         <td width="20%">
             <asp:Label ID="Label2" runat="server" CssClass="ntp_label" Text="Danh sách câu hỏi"></asp:Label></td>
         <td width="30%">
              </td>
         <td style="width: 20%">
             &nbsp;</td>
          <td style="width: 30%">
              </td>
     </tr>
        <tr>
            <td colspan="4" width="100%">
                <cc3:MultiSelectGrid ID="grdDS" runat="server" AllowPaging="True" AlternatingItemStyle-CssClass="ntp_grd_AltRowStyle"
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
                        <asp:TemplateColumn Visible="False">
                            <headerstyle width="2%" />
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="QUESTION_ID" HeaderText="QUESTION_ID" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn HeaderText="STT">
                            <headerstyle width="5%" />
                        </asp:BoundColumn>
                        <asp:TemplateColumn HeaderText="C&#226;u hỏi">
                            <itemtemplate>
<asp:GridView id="grdQuestion" runat="server" AutoGenerateColumns="False" __designer:wfdid="w3"><Columns>
<asp:TemplateField></asp:TemplateField>
<asp:BoundField DataField="TYPE" Visible="False"></asp:BoundField>
<asp:BoundField DataField="QUESTION_CONTENT"></asp:BoundField>
</Columns>
</asp:GridView>
</itemtemplate>
                            <headerstyle width="90%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn>
                            <itemtemplate>
<asp:Button id="cmdEditAnswer" runat="server" Text="Soạn câu trả lời" CssClass="ntp_textbox" __designer:wfdid="w2" CommandName="edit"></asp:Button>
</itemtemplate>
                            <headerstyle width="5%" />
                        </asp:TemplateColumn>
                    </Columns>
                    <HeaderStyle CssClass="ntp_grd_HeaderStyle" />
                </cc3:MultiSelectGrid></td>
        </tr>
       
    </table>
</asp:Panel>       






