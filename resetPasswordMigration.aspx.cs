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
    public partial class resetPasswordMigration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            //get the user - we should ONLY be here for users who hadn't set a question
            MembershipUser u = Membership.GetUser(GetUsername());
            if (u != null && u.PasswordQuestion != null)
            {
                throw new UnauthorizedAccessException();
            }

            PasswordRecovery.UserName = GetUsername();

            //if we have a file for the current culture then use it, else it will use the default
            if (System.IO.File.Exists(Server.MapPath(PasswordRecovery.MailDefinition.BodyFileName.Replace(".txt", ".")
                + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt")))
            {
                PasswordRecovery.MailDefinition.BodyFileName = PasswordRecovery.MailDefinition.BodyFileName.Replace(".txt", ".")
                    + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt";

                PasswordRecovery.MailDefinition.Subject = GetLocalResourceObject("NewPasswordEmailSubject").ToString();
            }
        }

        string GetUsername()
        {
            string keyname = null;
            if (Request != null && Request.Form != null && Request.Form.Keys.Count > 0)
            {
                foreach (string de in Request.Form.Keys)
                {
                    if (de.IndexOf("$UserName") > 0)
                    {
                        keyname = de;
                        break;
                    }
                }
            }

            return Request.Form[keyname];
        }
    }
}
