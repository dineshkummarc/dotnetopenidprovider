using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DotNetOpenId;

namespace DotOrg
{
    public partial class BaseMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ucStyle.Href = Request.ApplicationPath + "core.css";

            if (Request.IsAuthenticated)
            {
                ((HyperLink)LoginView1.FindControl("ucLoggedInAs")).NavigateUrl = "~/" + Context.User.Identity.Name;
                ((HyperLink)LoginView1.FindControl("ucLoggedInAs")).Text = GetLocalResourceObject("ucLoggedInAs.Text").ToString() + " " + Context.User.Identity.Name;
            }
        }

        public void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedValue.ToLower() != "en")
                Server.Transfer("~/help.txt");

            //set the language cookie
            HttpCookie cookie = new HttpCookie("OpenIDCulture");
            cookie.Value = ((ListBox)sender).SelectedValue;
            cookie.Expires = DateTime.Now.AddYears(10);

            //write the cookie
            Response.Cookies.Add(cookie);

            //clear any existing session
            Session["UserCulture"] = null;

            //we need to redirect to effect the culture changes
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}
