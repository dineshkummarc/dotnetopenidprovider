using System;
using System.IO;
using System.Net.Mail;
using System.Web.Security;

namespace DotOrg
{
    public partial class UnRegister : System.Web.UI.Page
    {
        const string AccountDeletionConfirmationPath = "~/EmailTemplates/AccountDeletionConfirmation.txt";
        const string AccountDeletionNotificationPath = "~/EmailTemplates/AccountDeletionNotification.txt";

        protected void ConfirmRemoval(object sender, EventArgs e)
        {
            string emailTo = null;
            string username = User.Identity.Name;

            //get the logged in user
            MembershipUser u = Membership.GetUser(User.Identity.Name);
            emailTo = u.Email;
            
            //now delete the user
            Membership.DeleteUser(User.Identity.Name);

            //confirms to user
            SendConfirmation(username, emailTo);

            //notifies admin
            SendNotification(username, emailTo);
        }

        void SendConfirmation(string username, string toemail)
        {
            string template = null;
            string path = AccountDeletionConfirmationPath;

            //if we have a file for the current culture then use it, else it will use the default
            if (System.IO.File.Exists(Server.MapPath(AccountDeletionConfirmationPath.Replace(".txt", ".")
                + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt")))
            {
                path = AccountDeletionConfirmationPath.Replace(".txt", ".")
                    + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt";
            }

            //read the template
            using (FileStream stream = new FileStream(Server.MapPath(path), FileMode.Open, FileAccess.Read))
            {
                using (StreamReader rdr = new StreamReader(stream, System.Text.Encoding.Unicode))
                {
                    template = rdr.ReadToEnd();
                }
            }

            //(1) Create the MailMessage instance
            MailMessage mm = new MailMessage(System.Configuration.ConfigurationManager.AppSettings["EmailAdmin"], toemail);

            //(2) Assign the MailMessage's properties
            mm.Subject = GetLocalResourceObject("AccountDeletionConfirmationSubject").ToString();
            mm.Body = template.Replace("<%UserName%>", username);
            mm.IsBodyHtml = false;

            //send using web.config settings
            SmtpClient client = new SmtpClient();
            client.Send(mm);

            //sign out the user and redirect to force login
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        void SendNotification(string username, string toemail)
        {
            string template = null;
            string path = AccountDeletionNotificationPath;

            //if we have a file for the current culture then use it, else it will use the default
            if (System.IO.File.Exists(Server.MapPath(AccountDeletionNotificationPath.Replace(".txt", ".")
                + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt")))
            {
                path = AccountDeletionNotificationPath.Replace(".txt", ".")
                    + System.Threading.Thread.CurrentThread.CurrentUICulture.Name + ".txt";
            }

            //read the template
            using (FileStream stream = new FileStream(Server.MapPath(path), FileMode.Open, FileAccess.Read))
            {
                using (StreamReader rdr = new StreamReader(stream, System.Text.Encoding.Unicode))
                {
                    template = rdr.ReadToEnd();
                }
            }

            //(1) Create the MailMessage instance
            MailMessage mm = new MailMessage(System.Configuration.ConfigurationManager.AppSettings["EmailAdmin"], System.Configuration.ConfigurationManager.AppSettings["EmailAdmin"]);

            //(2) Assign the MailMessage's properties
            mm.Subject = GetLocalResourceObject("AccountDeletionNotificationSubject").ToString();
            mm.Body = template.Replace("<%UserName%>", username).Replace("<%UserEmail%>", toemail).Replace("<%Reason%>", Body.Text);
            mm.IsBodyHtml = false;

            //send using web.config settings
            SmtpClient client = new SmtpClient();
            client.Send(mm);
        }
    }
}
