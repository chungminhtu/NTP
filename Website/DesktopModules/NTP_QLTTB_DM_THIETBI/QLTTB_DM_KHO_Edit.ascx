<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QLTTB_DM_KHO_Edit.ascx.vb" Inherits="QLTTB_DM_KHO_Edit" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.Containers" TagPrefix="cc2" %>
<%@ Register Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" TagPrefix="cc1" %>
&nbsp; &nbsp;&nbsp;&nbsp;<br />
&nbsp;<br />

<fieldset   class="ntp_fieldset">
&nbsp; &nbsp;&nbsp;<table>
        <tr>
            <td style="width: 80px">
                Mã thiết bị</td>
            <td style="width: 40px">
                <asp:TextBox ID="txt_mathietbi" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Tên thiết bị</td>
            <td style="width: 53px">
                <asp:TextBox ID="txt_tenthietbi" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Đơn vị tính</td>
            <td style="width: 53px">
                <asp:TextBox ID="txt_dvt" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Mã nước</td>
            <td style="width: 53px">
                <asp:TextBox ID="txt_manuoc" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Nhãn hiệu</td>
            <td style="width: 53px">
                <asp:TextBox ID="txt_nhanhieu" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <br />
&nbsp; 
    <asp:Button ID="btn_them" runat="server" Text="Thêm" />
    <asp:Button ID="btn_sua" runat="server" Text="Sửa" Width="49px" />
    &nbsp;
    <asp:Button ID="btn_xoa" runat="server" Text="Xóa" Width="51px" />
    <asp:Button ID="btn_huybo" runat="server" Text="Hủy bỏ" /></fieldset>



