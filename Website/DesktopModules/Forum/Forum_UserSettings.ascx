<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Forum_UserSettings.ascx.vb"
    Inherits="DotNetNuke.Modules.Forum.UserSettings" %>
<%@ Register TagPrefix="DNN" Namespace="DotNetNuke.UI.WebControls" Assembly="DotNetNuke.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="sectionhead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Register Src="~/DesktopModules/Forum/controls/Forum_AvatarAdminControl.ascx" TagName="AvatarControl" TagPrefix="FORUM" %>
<link href="<%= ForumConfig.Css() %>" type="text/css" rel="stylesheet" />
<table class="" id="tblMain" cellspacing="0" cellpadding="0" width="100%" align="center">
    <tr id="rowGeneralSettings" runat="server">
        <td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%">
            <dnn:sectionhead id="dshGeneral" runat="server" resourcekey="GeneralInformation" section="tblGeneral" width="100%"></dnn:sectionhead>
            <table id="tblGeneral" cellspacing="0" cellpadding="0" width="100%" runat="server">
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plUserID" runat="server" suffix=":" controlname="txtUserID"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtUserID" runat="server" CssClass="Forum_NormalTextBox" Width="50px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plUserName" runat="server" suffix=":" controlname="lblUserName"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:Label ID="lblUserName" runat="server" CssClass="Forum_Normal" Width="250px"></asp:Label></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plDisplayName" runat="server" suffix=":" controlname="lblDisplayName"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:Label ID="lblDisplayName" runat="server" CssClass="Forum_Normal" Width="250px"></asp:Label></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plWebsite" runat="server" suffix=":" controlname="lblWebsite"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:Label ID="lblWebsite" runat="server" CssClass="Forum_Normal" Width="250px"></asp:Label></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%">
            <dnn:sectionhead id="dshProfile" runat="server" resourcekey="UserProfile" section="tblProfile" width="100%" isexpanded="True"></dnn:sectionhead>
            <table id="tblProfile" cellspacing="0" cellpadding="0" width="100%" runat="server">
                            <tr id="rowEmail" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEmail" runat="server" suffix=":" controlname="chkDisplayEmail"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkDisplayEmail" runat="server" CssClass="Forum_NormalTextBox"></asp:CheckBox>&nbsp;
                        <asp:HyperLink ID="hlEmail" runat="server" CssClass="Forum_Link"></asp:HyperLink>        
                    </td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plMSN" runat="server" suffix=":" controlname="txtMSN"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtMSN" runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plYahoo" runat="server" suffix=":" controlname="txtYahoo"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtYahoo" runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plAIM" runat="server" suffix=":" controlname="txtAIM"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtAIM" runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plICQ" runat="server" suffix=":" controlname="txtICQ"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtICQ" runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plOccupation" runat="server" suffix=":" controlname="txtOccupation"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtOccupation" runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175" valign="top">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plInterests" runat="server" suffix=":" controlname="txtInterests"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtInterests" runat="server" CssClass="Forum_NormalTextBox" Width="250px"
                            TextMode="MultiLine" Height="75px" MaxLength="255"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%">
            <dnn:sectionhead id="dshSettings" runat="server" resourcekey="Settings" section="tblSettings" width="100%" isexpanded="False"></dnn:sectionhead>
            <table id="tblSettings" cellspacing="0" cellpadding="0" width="100%" runat="server">
                <tr id="rowSkin" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="dlSkin" runat="server" suffix=":" controlname="ddlSkins"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:DropDownList ID="ddlSkins" runat="server" CssClass="Forum_NormalTextBox" Width="250px"
                            AutoPostBack="False">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="dlCollapseGroups" runat="server" suffix=":" controlname="dlCollapseGroups"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:DropDownList ID="ddlCollapseGroups" runat="server" CssClass="Forum_NormalTextBox"
                            Width="250px">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plThreadsPerPage" runat="server" suffix=":" controlname="txtThreadsPerPage"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtThreadsPerPage" runat="server" CssClass="Forum_NormalTextBox"
                            Width="250px"></asp:TextBox>&nbsp;<asp:RegularExpressionValidator ID="Regularexpressionvalidator1"
                                runat="server" resourcekey="NumericValidation.ErrorMessage" CssClass="NormalRed"
                                ValidationExpression="[0-9]{1,}" ErrorMessage="Needs to be numeric!" ControlToValidate="txtThreadsPerPage"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plPostsPerPage" runat="server" suffix=":" controlname="txtPostsPerPage"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:TextBox ID="txtPostsPerPage" runat="server" CssClass="Forum_NormalTextBox" Width="250px"></asp:TextBox>&nbsp;<asp:RegularExpressionValidator
                            ID="Regularexpressionvalidator2" runat="server" resourcekey="NumericValidation.ErrorMessage"
                            CssClass="NormalRed" ValidationExpression="[0-9]{1,}" ErrorMessage="Needs to be numeric!"
                            ControlToValidate="txtPostsPerPage"></asp:RegularExpressionValidator></td>
                </tr>
                <tr id="rowSignature" runat="server">
                    <td class="Forum_Row_AdminL" valign="top" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plSignature" runat="server" suffix=":" controlname="txtSignature"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" valign="top" align="left">
                        <asp:TextBox ID="txtSignature" runat="server" CssClass="Forum_NormalTextBox" Width="250px"
                            TextMode="MultiLine" Rows="4"></asp:TextBox><asp:Label ID="lblSignature" runat="server"
                                CssClass="Forum_NormalTextBox" Width="250px" Visible="False"></asp:Label>&nbsp;<asp:ImageButton
                                    ID="btnPreview" runat="server" CommandName="preview" resourcekey="btnPreview"></asp:ImageButton><asp:ImageButton
                                        ID="btnEdit" runat="server" resourcekey="Edit" Visible="False" CommandName="edit">
                                    </asp:ImageButton></td>
                </tr>
                <tr id="rowOnlineStatus" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plOnlineStatus" runat="server" suffix=":" controlname="chkOnlineStatus"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkOnlineStatus" runat="server" CssClass="Forum_NormalTextBox"></asp:CheckBox></td>
                </tr>
                <tr id="rowMemberList" runat="server">
                    <td class="Forum_Row_AdminL" width="175"><span class="Forum_Row_AdminText">
                        <dnn:label id="plEnableMemberList" runat="server" ControlName="chkEnableMemberList" Suffix=":" /></span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR">
                        <asp:CheckBox ID="chkEnableMemberList" runat="server" CssClass="Forum_NormalTextBox" /></td>
                </tr>
                <tr id="rowEnablePM" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEnablePM" runat="server" suffix=":" controlname="chkEnablePM"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkEnablePM" runat="server" CssClass="Forum_NormalTextBox" AutoPostBack="True">
                        </asp:CheckBox></td>
                </tr>
                <tr id="rowPMNotification" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEnablePMNotifications" runat="server" suffix=":" controlname="chkEnablePMNotifications"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkEnablePMNotifications" runat="server" CssClass="Forum_NormalTextBox">
                        </asp:CheckBox></td>
                </tr>
                <tr id="rowForumModNotify" runat="server">
                    <td class="Forum_Row_AdminL" valign="middle" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEnableForumModNotify" runat="server" suffix=":" controlname="chkEnableForumModNotify"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkEnableForumModNotify" runat="server" CssClass="Forum_NormalTextBox">
                        </asp:CheckBox></td>
                </tr>
                <tr id="rowUserAvatar" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plAvatar" runat="server" suffix=":" controlname="ctlUserAvatar"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <forum:avatarcontrol id="ctlUserAvatar" runat="server"></forum:avatarcontrol>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%">
            <dnn:sectionhead id="dshTracking" runat="server" resourcekey="TrackingSettings" section="tblTracking" width="100%" isexpanded="False"></dnn:sectionhead>
            <table id="tblTracking" cellspacing="0" cellpadding="0" width="100%" runat="server">
                <tr>
                    <td class="Forum_Row_AdminL" valign="top" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plEmailFormat" runat="server" controlname="ddlEmailFormat" suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:DropDownList ID="ddlEmailFormat" runat="server" Width="250px" CssClass="Forum_NormalTextBox">
                        </asp:DropDownList></td>
                </tr>
                <tr id="rowTrackingForum" runat="server">
                    <td class="Forum_Row_AdminL" valign="top" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plTrackingForum" runat="server" suffix=":" controlname="TrackingTree"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <dnn:dnntree id="TrackingTree" runat="server"></dnn:dnntree>
                    </td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plClearReads" runat="server" controlname="cmdClearReads" suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:LinkButton class="Forum_Link" ID="cmdClearReads" runat="server" resourcekey="cmdClearReads"
                            ></asp:LinkButton></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="rowUserAdmin" runat="server">
        <td class="Forum_Admin_SectionHead" valign="top" align="left" width="100%">
            <dnn:sectionhead id="dshAdmin" runat="server" resourcekey="AdminSettings" section="tblAdmin" width="100%" isexpanded="False"></dnn:sectionhead>
            <table id="tblAdmin" cellspacing="0" cellpadding="0" width="100%" runat="server">
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plIsTrusted" runat="server" suffix=":" controlname="chkIsTrusted"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkIsTrusted" runat="server" CssClass="Forum_NormalTextBox"></asp:CheckBox></td>
                </tr>
                <tr>
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plLockTrust" runat="server" suffix=":" controlname="chkLockTrust"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkLockTrust" runat="server" CssClass="Forum_NormalTextBox"></asp:CheckBox></td>
                </tr>
                <tr id="rowUserBanning" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plIsBanned" runat="server" suffix=":" controlname="chkIsBanned"></dnn:label>
                        </span>
                    </td>
                    <td class="Forum_Row_AdminR" align="left">
                        <asp:CheckBox ID="chkIsBanned" runat="server" CssClass="Forum_NormalTextBox"></asp:CheckBox></td>
                </tr>
                <tr id="rowSystemAvatar" runat="server">
                    <td class="Forum_Row_AdminL" width="175">
                        <span class="Forum_Row_AdminText">
                            <dnn:label id="plSystemAvatarsLookup" runat="server" controlname="ctlSystemAvatar" suffix=":"></dnn:label>
                        </span>
                    </td>
                    <td align="left" class="Forum_Row_AdminR">
                        <forum:avatarcontrol id="ctlSystemAvatar" runat="server"></forum:avatarcontrol>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td valign="top" align="center" width="100%" class="Forum_Row_Admin_Foot">
            &nbsp;<asp:LinkButton class="CommandButton" ID="cmdUpdate" runat="server" resourcekey="cmdUpdate"></asp:LinkButton>&nbsp;
            <asp:LinkButton class="CommandButton" ID="cmdCancel" runat="server" resourcekey="cmdCancel"></asp:LinkButton><br />
            </td>
    </tr>
</table>
