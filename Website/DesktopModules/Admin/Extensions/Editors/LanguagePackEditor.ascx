<%@ Control language="vb" AutoEventWireup="false" Explicit="True" Inherits="DotNetNuke.Modules.Admin.Features.LanguagePackEditor" CodeFile="LanguagePackEditor.ascx.vb" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<asp:Panel ID="pnlHelp" runat="server">
    <br />
    <asp:Label ID="lblHelp" runat="server" cssClass="Normal" resourcekey="Help" />
    <br /><br />
</asp:Panel>
<table cellspacing="0" cellpadding="0" border="0">
    <tr id="trCoreLanguage" runat="server">
        <td colspan="2">
            <dnn:propertyeditorcontrol id="ctlLanguage" runat="Server"
                AutoGenerate="false"
                SortMode="SortOrderAttribute"
                editcontrolstyle-cssclass="NormalTextBox" 
                editcontrolwidth="325px" 
                ErrorStyle-cssclass="NormalRed"
                helpstyle-cssclass="Help" 
                labelstyle-cssclass="SubHead" 
                labelwidth="150px" 
                width="475px">
                <Fields>
                    <dnn:FieldEditorControl ID="fldCode" runat="server" DataField="Code" EditControlStyle-Width="300px" LabelMode="Top" EditorTypeName="DotNetNuke.UI.WebControls.DNNLocaleEditControl" />
                    <dnn:FieldEditorControl ID="fldFallback" runat="server" DataField="Fallback" EditControlStyle-Width="300px" LabelMode="Top" EditorTypeName="DotNetNuke.UI.WebControls.DNNLocaleEditControl" />
                </Fields>
            </dnn:propertyeditorcontrol>
        </td>
    </tr>
    <tr id="trEnabled" runat="server">
        <td class="SubHead" style="width:200px"><dnn:Label ID="plEnabled" runat="server" ControlName="chkEnabled" /></td>
        <td class="NormalTextBox" style="width:325px"><asp:CheckBox ID="chkEnabled" runat="server" /></td>
    </tr>
    <tr id="trPackageLanguage" runat="server">
        <td class="SubHead" style="width:200px"><dnn:Label ID="plPackageLanguage" runat="server" ControlName="cboLanguage" /></td>
        <td class="NormalTextBox" style="width:325px"><asp:DropDownList ID="cboLanguage" runat="server" DataTextField="Text" DataValueField="LanguageID"/></td>
    </tr>
    <tr id="trPackage" runat="server">
        <td class="SubHead" style="width:200px"><dnn:Label ID="plPackage" runat="server" ControlName="cboPackage" /></td>
        <td class="NormalTextBox" style="width:325px"><asp:DropDownList ID="cboPackage" runat="server" DataTextField="FriendlyName" DataValueField="PackageID"/></td>
    </tr>
</table>
<p style="text-align:center">
    <dnn:commandbutton id="cmdUpdate" runat="server" class="CommandButton" ImageUrl="~/images/save.gif"  ResourceKey="cmdUpdate" Visible="false" />
    <dnn:commandbutton id="cmdEdit" runat="server" class="CommandButton" ImageUrl="~/images/edit.gif"  ResourceKey="cmdEdit" />
</p>
