<%@ Control AutoEventWireup="false" Codebehind="Forum_AvatarAdminControl.ascx.vb"
    Inherits="DotNetNuke.Modules.Forum.AvatarAdminControl" Language="vb" %>
<table cellpadding="5" border="0" cellspacing="0">
    <tr>
        <td>
            <asp:Label ID="lblMessage" runat="server" CssClass="NormalRed"></asp:Label></td>
    </tr>
    <tr>
        <td>
            <asp:DataList ID="dlAvatars" runat="server" RepeatDirection="horizontal" RepeatColumns="3" ItemStyle-VerticalAlign="Bottom">
                <ItemTemplate>
                    <asp:Image ID="imgAvatar" runat="server" />
                    <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/images/delete.gif" CommandName="Delete" />
                    <asp:Label ID="lblImageName" runat="server" Visible="false" />
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
    <tr id="trFileList" runat="server" visible="false">
        <td>
            <asp:DropDownList ID="cboFiles" runat="server" CssClass="NormalTextBox" DataTextField="Text"
                DataValueField="Value" Width="300">
            </asp:DropDownList><br />
            <asp:LinkButton ID="cmdAdd" runat="server" CausesValidation="False" CssClass="CommandButton"
                resourcekey="Add">Add</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td id="trFileUpload" runat="server">
            <input id="txtFile" runat="server" name="txtFile" type="file" style="width:300px;" width="300"
                class="NormalTextbox" /><br />
            <asp:LinkButton ID="cmdUpload" runat="server" CausesValidation="False" CssClass="CommandButton"
                resourcekey="Upload">Upload</asp:LinkButton></td>
    </tr>
</table>
