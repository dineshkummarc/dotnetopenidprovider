using System;
using System.Web.Security;

namespace DotOrg
{
    public partial class changeEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //get the logged in user
                MembershipUser u = Membership.GetUser(User.Identity.Name);
                Email.Text = u.Email;
            }
        }

        public void UpdateDetails_OnClick(object sender, EventArgs args)
        {
            //get the logged in user
            MembershipUser u = Membership.GetUser(User.Identity.Name);

            //check the password before we make any changes
            if (!Membership.ValidateUser(User.Identity.Name, Password.Text))
            {
                //ucMainContainer.Visible = false;
                ucMessageContainer.Visible = true;
                ucMessages.Text = GetLocalResourceObject("InvalidPassword").ToString();
                return;
            }

            //do we have an email change?
            if (Email.Text.Trim() != u.Email && Membership.FindUsersByEmail(Email.Text.Trim()).Count == 0)
            {
                u.Email = Email.Text.Trim();
                Membership.UpdateUser(u);

                ucMainContainer.Visible = false;
                ucMessageContainer.Visible = true;
                ucMessages.Text = GetLocalResourceObject("EmailAddressSuccess").ToString();
            }
        }
    }
}
