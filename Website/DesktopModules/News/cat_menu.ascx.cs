using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;

namespace News
{
    public partial class cat_menu : DotNetNuke.Entities.Modules.PortalModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (RoleProvider.IsAdminRole(PortalSettings.AdministratorRoleName))
                {
                    lnkAdmin.NavigateUrl = DotNetNuke.Common.Globals.NavigateURL(PortalSettings.ActiveTab.TabID, "admin", "mid/" + this.ModuleId.ToString());
                    lnkAdmin.Visible = true;
                }
                else lnkAdmin.Visible = false;
                lnkAdmin.Visible = true;

                if (!Page.IsPostBack)
                {
                    CategoryController engine = new CategoryController();
                    string editFormat = DotNetNuke.Common.Globals.NavigateURL(PortalSettings.ActiveTab.TabID, "edit", "mid/" + this.ModuleId.ToString(), "id/@@catid");
                    XmlDocument doc = engine.LoadTreeXML("", true);
                    string template = "DesktopModules/news/cat_menu.xsl";
                    Providers.Utils.XMLTransform(xmlTransformer, template, doc);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}