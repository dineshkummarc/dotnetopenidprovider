﻿using System;
using DotNetOpenId.Provider;

namespace DotOrg
{
    public partial class server : System.Web.UI.Page
    {
        protected void Page_Load(object src, System.EventArgs evt)
        {
            serverEndpointUrl.Text = String.Format(GetLocalResourceObject("serverEndpointUrl").ToString(), Request.Url.ToString());
        }
        protected void provider_AuthenticationChallenge(object sender, AuthenticationChallengeEventArgs e)
        {
            var idrequest = e.Request;
            if (idrequest.Immediate)
            {
                if (idrequest.IsDirectedIdentity)
                {
                    if (User.Identity.IsAuthenticated)
                    {
                        idrequest.LocalIdentifier = Util.BuildIdentityUrl();
                        idrequest.IsAuthenticated = true;
                    }
                    else
                    {
                        idrequest.IsAuthenticated = false;
                    }
                }
                else
                {
                    string userOwningOpenIdUrl = Util.ExtractUserName(idrequest.LocalIdentifier);
                    // NOTE: in a production provider site, you may want to only 
                    // respond affirmatively if the user has already authorized this consumer
                    // to know the answer.
                    idrequest.IsAuthenticated = userOwningOpenIdUrl == User.Identity.Name;
                }
            }
            else
            {
                Response.Redirect("~/decide.aspx", true); // This ends processing on this page.
            }
        }
    }
}
