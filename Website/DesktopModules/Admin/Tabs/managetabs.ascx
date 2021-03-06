<%@ Control Language="vb" AutoEventWireup="false" Explicit="True" CodeFile="ManageTabs.ascx.vb" Inherits="DotNetNuke.Modules.Admin.Tabs.ManageTabs" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="URL" Src="~/controls/URLControl.ascx" %>
<%@ Register TagPrefix="Portal" Namespace="DotNetNuke.Security.Permissions.Controls" Assembly="DotNetNuke" %>
<%@ Register TagPrefix="dnn" TagName="Skin" Src="~/controls/SkinControl.ascx" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.UI.WebControls" Assembly="DotNetNuke" %>
<table cellspacing="2" cellpadding="2" summary="Manage Tabs Design Table" border="0">
    <tr>
        <td width="760" valign="top">
            <asp:Panel ID="pnlSettings" runat="server" CssClass="WorkPanel" Visible="True">
                <dnn:SectionHead ID="dshBasic" CssClass="Head" runat="server" Text="Basic Settings"
                    Section="tblBasic" ResourceKey="BasicSettings" IncludeRule="True"/>
                <table id="tblBasic" cellspacing="0" cellpadding="2" width="725" summary="Basic Settings Design Table"
                    border="0" runat="server">
                    <tr>
                        <td colspan="2"><asp:Label ID="lblBasicSettingsHelp" CssClass="Normal" runat="server" resourcekey="BasicSettingsHelp" EnableViewState="False"/></td>
                    </tr>
                    <tr>
                        <td width="25"></td>
                        <td valign="top" width="725">
                            <dnn:SectionHead ID="dshPage" CssClass="Head" runat="server" Text="Page Details"
                                Section="tblPage" ResourceKey="PageDetails"/>
                            <table id="tblPage" cellspacing="2" cellpadding="2" summary="Site Details Design Table" border="0" runat="server">
                                <tr>
                                    <td class="SubHead" width="200">
                                        <dnn:Label ID="plTabName" runat="server" ResourceKey="TabName" Suffix=":" HelpKey="TabNameHelp" ControlName="txtTabName"/>
                                    </td>
                                    <td width="525">
                                        <asp:TextBox ID="txtTabName" CssClass="NormalTextBox" runat="server" MaxLength="50" Width="300"/>
                                        <asp:RequiredFieldValidator ID="valTabName" CssClass="NormalRed" runat="server" resourcekey="valTabName.ErrorMessage" Display="Dynamic" ControlToValidate="txtTabName"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" width="200"><dnn:Label ID="plTitle" runat="server" ResourceKey="Title" Suffix=":" HelpKey="TitleHelp" ControlName="txtTitle"/></td>
                                    <td><asp:TextBox ID="txtTitle" CssClass="NormalTextBox" runat="server" MaxLength="200" Width="300"/></td>
                                </tr>
                                <tr>
                                    <td class="SubHead" width="200"><dnn:Label ID="plDescription" runat="server" ResourceKey="Description" Suffix=":" HelpKey="DescriptionHelp" ControlName="txtDescription"/></td>
                                    <td class="NormalTextBox" width="525"><asp:TextBox ID="txtDescription" CssClass="NormalTextBox" runat="server" MaxLength="500" Width="300" TextMode="MultiLine" Rows="3"/></td>
                                </tr>
                                <tr>
                                    <td class="SubHead" width="200"><dnn:Label ID="plKeywords" runat="server" ResourceKey="KeyWords" Suffix=":" HelpKey="KeyWordsHelp" ControlName="txtKeyWords"/></td>
                                    <td class="NormalTextBox" width="525"><asp:TextBox ID="txtKeyWords" CssClass="NormalTextBox" runat="server" MaxLength="500" Width="300" TextMode="MultiLine" Rows="3"/></td>
                                </tr>
                                <tr>
                                    <td class="SubHead" width="200"><dnn:Label ID="plParentTab" runat="server" ResourceKey="ParentTab" ControlName="cboParentTab"/></td>
                                    <td width="325"><asp:DropDownList ID="cboParentTab" CssClass="NormalTextBox" runat="server" Width="300" DataTextField="IndentedTabName" DataValueField="TabId"/></td>
                                </tr>
                                <tr id="trInsertPositionRow" runat="server">
                                    <td class="SubHead" width="200"><dnn:Label ID="plInsertPosition" runat="server" ResourceKey="InsertPosition" ControlName="cboPositionTab" /></td>
                                    <td width="525">
                                        <asp:RadioButtonList ID="rbInsertPosition" runat="server" CssClass="Normal" RepeatDirection="Horizontal" AutoPostBack="true"/>
                                        <asp:DropDownList ID="cboPositionTab" CssClass="NormalTextBox" runat="server" Width="300" DataTextField="LocalizedTabName" DataValueField="TabId"/>
                                    </td>
                                </tr>
                                <tr id="rowTemplate1" runat="Server" visible="false">
                                    <td class="SubHead" style="vertical-align:top; width:150px;"><dnn:label id="plFolder" runat="server" controlname="cboFolders" /></td>
                                    <td><asp:DropDownList ID="cboFolders" Runat="server" CssClass="NormalTextBox" Width="300" AutoPostBack="true" /></td>
                                </tr>
	                            <tr id="rowTemplate2" runat="Server" visible="false">
		                            <td class="SubHead" style="vertical-align:top; width:150px;"><dnn:label id="plTemplate" runat="server" controlname="cboTemplate" /></td>
		                            <td style="vertical-align:top;"><asp:dropdownlist id="cboTemplate" cssclass="NormalTextBox" runat="server" width="300" /></td>
	                            </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200"><dnn:Label ID="plMenu" runat="server" ResourceKey="Menu" Suffix="?" HelpKey="MenuHelp" ControlName="chkMenu"/></td>
                                    <td width="525"><asp:CheckBox ID="chkMenu" runat="server" Font-Size="8pt" Font-Names="Verdana,Arial"/></td>
                                </tr>
                                <tr id="rowPerm" runat="server">
                                    <td class="SubHead" valign="top" width="200">
                                        <br/>
                                        <br/>
                                        <dnn:Label ID="plPermissions" runat="server" ResourceKey="Permissions" Suffix=":" HelpKey="PermissionsHelp" ControlName="dgPermissions"/>
                                    </td>
                                    <td width="525"><Portal:TabPermissionsGrid ID="dgPermissions" runat="server"/></td>
                                </tr>
                                <tr id="rowCopyPerm" runat="server">
                                    <td class="SubHead"><dnn:Label ID="plCopyPerm" runat="server" ResourceKey="plCopyPerm" /></td>
                                    <td><asp:LinkButton ID="cmdCopyPerm" runat="server" CssClass="CommandButton" resourcekey="cmdCopyPerm"/></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <br>
                <dnn:SectionHead ID="dshCopy" CssClass="Head" runat="server" Text="Copy Page" Section="tblCopy"
                    ResourceKey="Copy" IncludeRule="True"></dnn:SectionHead>
                <table id="tblCopy" cellspacing="0" cellpadding="2" width="725" summary="Copy Tab Design Table"
                    border="0" runat="server">
                    <tr>
                        <td width="25">
                        </td>
                        <td class="SubHead" width="200">
                            <dnn:Label ID="plCopyPage" runat="server" ResourceKey="CopyModules" Suffix=":" HelpKey="CopyModulesHelp"
                                ControlName="cboCopyPage"></dnn:Label>
                        </td>
                        <td width="525">
                            <asp:DropDownList ID="cboCopyPage" CssClass="NormalTextBox" runat="server" Width="300"
                                DataTextField="IndentedTabName" DataValueField="TabId" AutoPostBack="True">
                            </asp:DropDownList></td>
                    </tr>
                    <tr id="rowModules" runat="server">
                        <td width="25">
                        </td>
                        <td class="SubHead" colspan="2">
                            <dnn:Label ID="plModules" runat="server" ResourceKey="CopyContent" Suffix=":" HelpKey="CopyContentHelp"
                                ControlName="grdModules"></dnn:Label>
                            <br>
                            <asp:DataGrid ID="grdModules" runat="server" DataKeyField="ModuleID" ShowHeader="False"
                                ItemStyle-CssClass="Normal" GridLines="None" BorderWidth="0px" BorderStyle="None"
                                AutoGenerateColumns="False" CellSpacing="0" CellPadding="0" Width="100%">
                                <Columns>
                                    <asp:TemplateColumn>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkModule" runat="server" CssClass="NormalTextBox" Checked="True" />
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtCopyTitle" width="200" runat="server" CssClass="NormalTextBox"
                                                Text='<%# Databinder.eval(Container.Dataitem,"ModuleTitle")%>'>
                                            </asp:TextBox>
                                        </ItemTemplate>
                                        <ItemStyle Wrap="False"></ItemStyle>
                                    </asp:TemplateColumn>
                                    <asp:BoundColumn runat="server" DataField="PaneName" />
                                    <asp:TemplateColumn>
                                        <ItemTemplate>
                                            <asp:RadioButton ID="optNew" runat="server" CssClass="NormalBold" GroupName="Copy"
                                                Text="New" resourcekey="ModuleNew" Checked="True"></asp:RadioButton>
                                            <asp:RadioButton ID="optCopy" runat="server" CssClass="NormalBold" GroupName="Copy"
                                                Text="Copy" resourcekey="ModuleCopy" Enabled='<%# DataBinder.Eval(Container.DataItem, "IsPortable") %>'>
                                            </asp:RadioButton>
                                            <asp:RadioButton ID="optReference" runat="server" CssClass="NormalBold" GroupName="Copy"
                                                Text="Reference" resourcekey="ModuleReference" Enabled='<%# DataBinder.Eval(Container.DataItem, "ModuleID") <> -1  %>'>
                                            </asp:RadioButton>
                                        </ItemTemplate>
                                        <ItemStyle Wrap="False"></ItemStyle>
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid></td>
                    </tr>
                </table>
                <br>
                <dnn:SectionHead ID="dshAdvanced" CssClass="Head" runat="server" Text="Advanced Settings"
                    Section="tblAdvanced" ResourceKey="AdvancedSettings" IncludeRule="True" IsExpanded="False"></dnn:SectionHead>
                <table id="tblAdvanced" cellspacing="0" cellpadding="2" width="725" summary="Advanced Settings Design Table"
                    border="0" runat="server">
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblAdvancedSettingsHelp" CssClass="Normal" runat="server" resourcekey="AdvancedSettingsHelp"
                                EnableViewState="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td width="25">
                        </td>
                        <td valign="top" width="725">
                            <dnn:SectionHead ID="dhsAppearance" CssClass="Head" runat="server" Text="Appearance"
                                Section="tblAppearance" ResourceKey="Appearance"></dnn:SectionHead>
                            <table id="tblAppearance" cellspacing="2" cellpadding="2" summary="Appearance Design Table"
                                border="0" runat="server">
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plIcon" runat="server" ResourceKey="Icon" Suffix=":" HelpKey="IconHelp"
                                            ControlName="ctlIcon"></dnn:Label>
                                    </td>
                                    <td width="325">
                                        <dnn:URL ID="ctlIcon" runat="server" Width="300" ShowLog="False"></dnn:URL>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plSkin" runat="server" ResourceKey="TabSkin" Suffix=":" HelpKey="TabSkinHelp"
                                            ControlName="ctlSkin"></dnn:Label>
                                    </td>
                                    <td valign="top" width="525">
                                        <dnn:Skin ID="ctlSkin" runat="server" Width="450px"></dnn:Skin>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plContainer" runat="server" ResourceKey="TabContainer" Suffix=":"
                                            HelpKey="TabContainerHelp" ControlName="ctlContainer"></dnn:Label>
                                    </td>
                                    <td valign="top" width="525">
                                        <dnn:Skin ID="ctlContainer" runat="server"></dnn:Skin>
                                    </td>
                                </tr>
                                <tr id="rowCopySkin" runat="server">
                                    <td class="SubHead">
                                        <dnn:Label ID="plCopySkin" runat="server" ResourceKey="plCopySkin" />
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="cmdCopySkin" runat="server" CssClass="CommandButton" resourcekey="cmdCopySkin"></asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plDisable" runat="server" ResourceKey="Disabled" Suffix=":" HelpKey="DisabledHelp"
                                            ControlName="chkDisableLink"></dnn:Label>
                                    </td>
                                    <td width="525">
                                        <asp:CheckBox ID="chkDisableLink" runat="server" Font-Size="8pt" Font-Names="Verdana,Arial">
                                        </asp:CheckBox></td>
                                </tr>
                                <tr>
                                    <td class="SubHead" width="200">
                                        <dnn:Label ID="plRefreshInterval" runat="server" ResourceKey="RefreshInterval" Suffix=":"
                                            HelpKey="RefreshInterval.Help" ControlName="cboRefreshInterval" columns="10"></dnn:Label>
                                    </td>
                                    <td width="525">
                                        <asp:TextBox ID="txtRefreshInterval" CssClass="NormalTextBox" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plPageHeadText" runat="server" ResourceKey="PageHeadText" Suffix=":"
                                            HelpKey="PageHeadText.Help" ControlName="txtPageHeadText"></dnn:Label>
                                    </td>
                                    <td class="NormalTextBox" width="525">
                                        <asp:TextBox ID="txtPageHeadText" CssClass="NormalTextBox" runat="server" TextMode="MultiLine" MaxLength="500"
                                            Rows="4" Columns="50"></asp:TextBox></td>
                                </tr>
                            </table>
                            <br>
                            <dnn:SectionHead ID="dshOther" CssClass="Head" runat="server" Text="Other Settings"
                                Section="tblOther" ResourceKey="OtherSettings"></dnn:SectionHead>
                            <table id="tblOther" cellspacing="2" cellpadding="2" summary="Appearance Design Table"
                                border="0" runat="server">
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plSecure" runat="server" Text="Secure?" ControlName="chkSecure"></dnn:Label>
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="chkSecure" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plStartDate" runat="server" Text="Start Date:" ControlName="txtStartDate"></dnn:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtStartDate" CssClass="NormalTextBox" runat="server" MaxLength="11" Width="120" Columns="30"/>&nbsp;
                                        <asp:HyperLink ID="cmdStartCalendar" CssClass="CommandButton" runat="server" resourcekey="Calendar"/>
                                        <asp:CompareValidator ID="valtxtStartDate" resourcekey="valStartDate.ErrorMessage" Operator="DataTypeCheck" Type="Date" runat="server" Display="Dynamic" ControlToValidate="txtStartDate"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plEndDate" runat="server" Text="End Date:" ControlName="txtEndDate"></dnn:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtEndDate" CssClass="NormalTextBox" runat="server" MaxLength="11" Width="120" Columns="30"/>&nbsp;
                                        <asp:HyperLink ID="cmdEndCalendar" CssClass="CommandButton" runat="server" resourcekey="Calendar"/>
                                        <asp:CompareValidator ID="valtxtEndDate" resourcekey="valEndDate.ErrorMessage" Operator="DataTypeCheck" Type="Date" runat="server" Display="Dynamic" ControlToValidate="txtEndDate"/>
									    <asp:CompareValidator ID="val2txtEndDate" ControlToValidate="txtEndDate" ControlToCompare="txtStartdate" Operator="GreaterThanEqual" Type="Date" Runat="server" Display="Dynamic" resourcekey="valEndDate2.ErrorMessage" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="SubHead" valign="top" width="200">
                                        <dnn:Label ID="plURL" runat="server" ResourceKey="Url" Suffix=":" HelpKey="UrlHelp"
                                            ControlName="ctlURL"></dnn:Label>
                                    </td>
                                    <td class="NormalTextBox" width="325">
                                        <dnn:URL ID="ctlURL" runat="server" Width="300" ShowLog="False" ShowNone="True" ShowTrack="False" IncludeActiveTab="False"></dnn:URL>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
</table>
<p>
    <dnn:CommandButton ID="cmdUpdate" resourcekey="cmdUpdate" runat="server" CssClass="CommandButton" ImageUrl="~/images/save.gif" />&nbsp;
    <dnn:CommandButton ID="cmdDelete" resourcekey="cmdDelete" runat="server" CssClass="CommandButton" ImageUrl="~/images/delete.gif" CausesValidation="False" />&nbsp;
    <dnn:CommandButton ID="cmdCancel" resourcekey="cmdCancel" runat="server" CssClass="CommandButton" ImageUrl="~/images/lt.gif" CausesValidation="False" />
</p>
