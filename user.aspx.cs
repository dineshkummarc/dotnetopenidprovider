using System;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetOpenId.Provider;

namespace DotOrg
{
    public partial class user : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Request.QueryString["username"];
        }
    }
}
