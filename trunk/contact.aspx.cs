using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Net.Mail;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace DotOrg
{
    public partial class contact : System.Web.UI.Page
    {
        protected void SendEmail_Click(object sender, System.EventArgs e)
        {
            //(1) Create the MailMessage instance
            MailMessage mm = new MailMessage(System.Configuration.ConfigurationManager.AppSettings["EmailAdmin"], System.Configuration.ConfigurationManager.AppSettings["EmailAdmin"]);

            //(2) Assign the MailMessage's properties
            mm.Subject = Subject.Text;
            mm.Body = UsersEmail.Text + Environment.NewLine + Environment.NewLine + Body.Text;
            mm.IsBodyHtml = false;

            //send using web.config settings
            SmtpClient client = new SmtpClient();
            client.Send(mm);

            ucMainContainer.Visible = false;
            ucMessageContainer.Visible = true;
            ucMessages.Text = GetLocalResourceObject("EmailSentMessage").ToString();
        }
    }
}
