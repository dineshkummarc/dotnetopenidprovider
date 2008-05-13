using System;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace DotOrg
{
    public partial class changeSecretQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Question != null)
                {
                    Question.Items.Add(GetLocalResourceObject("SecurityQuestion1").ToString());
                    Question.Items.Add(GetLocalResourceObject("SecurityQuestion2").ToString());
                    Question.Items.Add(GetLocalResourceObject("SecurityQuestion3").ToString());
                }

                //get the logged in user
                MembershipUser u = Membership.GetUser(User.Identity.Name);
                Question.SelectedValue = u.PasswordQuestion;
            }
        }

        public void UpdateDetails_OnClick(object sender, EventArgs args)
        {
            //check the password before we make any changes
            if (!Membership.ValidateUser(User.Identity.Name, Password.Text))
            {
                ucMessageContainer.Visible = true;
                ucMessages.Text = GetLocalResourceObject("InvalidPassword").ToString();
                return;
            }

            //get the logged in user
            MembershipUser u = Membership.GetUser(User.Identity.Name);
            u.ChangePasswordQuestionAndAnswer(Password.Text, Question.Text, Answer.Text);
            ucChangeQuestionPanel.Visible = false;
            ucMessageContainer.Visible = true;
            ucMessages.Text = GetLocalResourceObject("SecretChanged").ToString(); 
        }
    }
}
