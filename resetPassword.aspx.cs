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
    public partial class resetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MembershipUser u = null;
            ListBox Question = PasswordRecovery.QuestionTemplateContainer.FindControl("Question") as ListBox;

            //if we have a file for the current culture then use it, else it will use the default
            if (System.IO.File.Exists(Server.MapPath(PasswordRecovery.MailDefinition.BodyFileName.Replace(".txt", ".")
                + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt")))
            {
                PasswordRecovery.MailDefinition.BodyFileName = PasswordRecovery.MailDefinition.BodyFileName.Replace(".txt", ".")
                    + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt";

                PasswordRecovery.MailDefinition.Subject = GetLocalResourceObject("NewPasswordEmailSubject").ToString();
            }

            if (IsPostBack)
            {
                u = Membership.GetUser((PasswordRecovery.UserNameTemplateContainer.FindControl("UserName") as TextBox).Text);
                if (u != null && u.PasswordQuestion == null)
                    Server.Transfer("~/resetPasswordMigration.aspx"); //used for users migrating from old database which didn't use questions
            }

            if (IsPostBack && Question.Items.Count == 0)
            {
                //get the logged in user
                if (u == null) u = Membership.GetUser((PasswordRecovery.UserNameTemplateContainer.FindControl("UserName") as TextBox).Text);

                if (u != null && u.PasswordQuestion != null)
                    Question.SelectedValue = u.PasswordQuestion;

                if (Question != null)
                {
                    Question.Items.Add(GetLocalResourceObject("SecurityQuestion1").ToString());
                    Question.Items.Add(GetLocalResourceObject("SecurityQuestion2").ToString());
                    Question.Items.Add(GetLocalResourceObject("SecurityQuestion3").ToString());
                }
            }
        }
    }
}
