<%@ Register TagPrefix="dnnforum" Namespace="DotNetNuke.Modules.Forum.WebControls"
    Assembly="DotNetNuke.Modules.Forum" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Control Language="vb" Codebehind="Forum_Avatars.ascx.vb" AutoEventWireup="false"
    Inherits="DotNetNuke.Modules.Forum.Avatars" %>
<link href='<%= ForumConfig.Css() %>' type="text/css" rel="stylesheet" />
<table class="" id="tblMain" cellspacing="0" cellpadding="0" align="center" width="100%">
    <tr valign="middle">
        <td width="100%">
            <table id="tblGallery" cellspacing="0" cellpadding="0" width="100%" runat="server">
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEnableUserAvatar" runat="server" controlname="chkEnableUserAvatar" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:CheckBox ID="chkEnableUserAvatar" runat="server" CssClass="Forum_NormalTextBox">
                        </asp:CheckBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEnableUserAvatarPool" runat="server" controlname="chkEnableUserAvatarPool" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR" width="70%">
                        <asp:CheckBox ID="chkEnableUserAvatarPool" runat="server" CssClass="Forum_NormalTextBox" /></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plUserAvatarPath" runat="server" controlname="txtUserAvatarPath" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:TextBox ID="txtUserAvatarPath" runat="server" CssClass="Forum_NormalTextBox"
                            Width="350px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plUserAvatarDimensions" runat="server" 
                                controlname="txtUserAvatarWidth" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:TextBox ID="txtUserAvatarWidth" runat="server" CssClass="Forum_NormalTextBox"
                            Width="50px"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblWidth" runat="server" CssClass="Forum_Row_AdminText"></asp:Label>&nbsp;
                        <asp:Label ID="lblx1" runat="server" CssClass="Forum_Row_AdminText">x</asp:Label>&nbsp;
                        <asp:TextBox ID="txtUserAvatarHeight" runat="server" CssClass="Forum_NormalTextBox"
                            Width="50px"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblHeight" runat="server" CssClass="Forum_Row_AdminText"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plUserAvatarSizeLimit" runat="server" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:TextBox ID="txtUserAvatarSizeLimit" runat="server" CssClass="Forum_NormalTextBox"
                            Width="50px"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblKB1" runat="server" CssClass="Forum_Row_AdminText"></asp:Label></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEnableSystemAvatar" runat="server" controlname="ddlUserGallery"
                                 Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:CheckBox ID="chkEnableSystemAvatar" runat="server" CssClass="Forum_NormalTextBox">
                        </asp:CheckBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plSystemAvatarPath" runat="server" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:TextBox ID="txtSystemAvatarPath" runat="server" CssClass="Forum_NormalTextBox"
                            Width="350px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plSystemAvatarDimensions" runat="server" controlname="txtSystemAvatarWidth" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:TextBox ID="txtSystemAvatarWidth" runat="server" CssClass="Forum_NormalTextBox"
                            Width="50px"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblWidth2" runat="server" CssClass="Forum_Row_AdminText"></asp:Label>
                        &nbsp;
                        <asp:Label ID="lblx2" runat="server" CssClass="Forum_Row_AdminText">x</asp:Label>&nbsp;
                        <asp:TextBox ID="txtSystemAvatarHeight" runat="server" CssClass="Forum_NormalTextBox"
                            Width="50px"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblHeight2" runat="server" CssClass="Forum_Row_AdminText"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="30%" valign="top">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plSystemAvatarSizeLimit" runat="server" Suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left" width="70%">
                        <asp:TextBox ID="txtSystemAvatarSizeLimit" runat="server" CssClass="Forum_NormalTextBox"
                            Width="50px"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblKB2" runat="server" CssClass="Forum_Row_AdminText"></asp:Label></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="Forum_Row_Admin_Foot" align="center" width="100%">
            <asp:LinkButton class="CommandButton" ID="cmdUpdate" runat="server" resourcekey="cmdUpdate"></asp:LinkButton>&nbsp;
            <asp:LinkButton class="CommandButton" ID="cmdCancel" runat="server" resourcekey="cmdCancel"
                CausesValidation="False"></asp:LinkButton></td>
    </tr>
    <tr>
        <td>
        <asp:ValidationSummary ID="validSum" runat="server" CssClass="NormalRed" />
            <asp:CompareValidator ID="validUserDimWidth" runat="server" ControlToValidate="txtUserAvatarWidth"
                CssClass="NormalRed" Display="None" ErrorMessage="Invalid value for user avatar width."
                resourcekey="validUserDimWidth" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
            <asp:CompareValidator ID="validUserDimHeight" runat="server" ControlToValidate="txtUserAvatarHeight"
                CssClass="NormalRed" Display="None" ErrorMessage="Invalid value for user avatar height."
                resourcekey="validUserDimHeight" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
            <asp:CompareValidator ID="validUserSize" runat="server" ControlToValidate="txtUserAvatarSizeLimit"
                CssClass="NormalRed" Display="None" ErrorMessage="Invalid value for user avatar size limit."
                resourcekey="validUserSize" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
            <asp:CompareValidator ID="validSystemDimWidth" runat="server" ControlToValidate="txtSystemAvatarWidth"
                CssClass="NormalRed" Display="None" ErrorMessage="Invalid value for system avatar width."
                resourcekey="validSystemDimWidth" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
            <asp:CompareValidator ID="validSystemDimHeight" runat="server" ControlToValidate="txtSystemAvatarHeight"
                CssClass="NormalRed" Display="None" ErrorMessage="Invalid value for system avatar height."
                Operator="DataTypeCheck" resourcekey="validSystemDimHeight" SetFocusOnError="True"
                Type="Integer"></asp:CompareValidator>
            <asp:CompareValidator ID="validSystemSize" runat="server" ControlToValidate="txtSystemAvatarSizeLimit"
                CssClass="NormalRed" Display="None" ErrorMessage="Invalid value for system avatar size limit."
                Operator="DataTypeCheck" resourcekey="validSystemSize" SetFocusOnError="True"
                Type="Integer"></asp:CompareValidator>
        </td>
    </tr>
</table>
