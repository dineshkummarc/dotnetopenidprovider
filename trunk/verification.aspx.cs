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

namespace DotOrg
{
    public partial class verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["ID"]))
                StatusMessage.Text = GetLocalResourceObject("MissingUserID").ToString();
             else
            {
                  Guid userId;
                  try
                  {
                       userId = new Guid(Request.QueryString["ID"]);
                  }
                  catch
                  {
                      StatusMessage.Text = GetLocalResourceObject("InvalidUserID").ToString();
                       return;
                  }

                  MembershipUser usr = Membership.GetUser(userId);
                  if (usr == null)
                       StatusMessage.Text = GetLocalResourceObject("NotFoundUserID").ToString();
                  else
                  {
                       // Approve the user
                       usr.IsApproved = true;
                       Membership.UpdateUser(usr);
                       StatusMessage.Text = GetLocalResourceObject("Success").ToString();
                  }
             }

        }
    }
}
