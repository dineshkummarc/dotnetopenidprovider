using System;
using System.Web.UI.WebControls;
using DotNetOpenId.Provider;

namespace DotOrg
{
    /// <summary>
    /// Page for handling logins to this server. 
    /// </summary>
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ProviderEndpoint.PendingAuthenticationRequest != null &&
                    !ProviderEndpoint.PendingAuthenticationRequest.IsDirectedIdentity)
                {
                    ucLogin.UserName = Util.ExtractUserName(
                        ProviderEndpoint.PendingAuthenticationRequest.LocalIdentifier);
                    ((TextBox)ucLogin.FindControl("UserName")).ReadOnly = true;
                    ucLogin.FindControl("Password").Focus();
                }
            }
        }
    }
}
