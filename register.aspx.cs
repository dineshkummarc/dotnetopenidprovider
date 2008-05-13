using System;
using System.Web.Security;
using System.Web.UI.WebControls;
using DotNetOpenId.Provider;

namespace DotOrg
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if we have a file for the current culture then use it, else it will use the default
            if (System.IO.File.Exists(Server.MapPath(UserWizard.MailDefinition.BodyFileName.Replace(".txt", ".")
                + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt")))
            {
                UserWizard.MailDefinition.BodyFileName = UserWizard.MailDefinition.BodyFileName.Replace(".txt", ".")
                    + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt";

                UserWizard.MailDefinition.Subject = GetLocalResourceObject("NewUserEmailSubject").ToString();
            }

            ListBox Question = UserWizard.WizardSteps[0].Controls[0].FindControl("Question") as ListBox;
            if (Question != null)
            {
                Question.Items.Add(GetLocalResourceObject("SecurityQuestion1").ToString());
                Question.Items.Add(GetLocalResourceObject("SecurityQuestion2").ToString());
                Question.Items.Add(GetLocalResourceObject("SecurityQuestion3").ToString());
            }
        }

        protected void SendMail(object sender, MailMessageEventArgs e)
        {
            // Get the UserId of the just-added user
            MembershipUser newUser = Membership.GetUser(UserWizard.UserName);
            Guid newUserId = (Guid)newUser.ProviderUserKey;

            // Determine the full verification URL
            string urlBase = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath;

            if (!urlBase.EndsWith("/")) urlBase += "/";

            string verifyUrl = "Verification.aspx?ID=" + newUserId.ToString();
            string fullUrl = urlBase + verifyUrl;
            
            //set the subject
            e.Message.Subject = GetLocalResourceObject("NewUserSubject").ToString();

            // Replace <%VerificationUrl%> with the appropriate URL and querystring
            e.Message.Body = e.Message.Body.Replace("<%VerificationUrl%>", fullUrl);
        }
    }
}
