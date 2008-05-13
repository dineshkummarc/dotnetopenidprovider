using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace DotOrg
{
    public partial class stats : System.Web.UI.UserControl
    {
        const string TOTALUSERCOUNT = "TOTALUSERCOUNT";
        const string TOTALUSERSONLINE = "TOTALUSERSONLINE";

        protected void Page_Load(object sender, EventArgs e)
        {
            //make sure this doesn't break no matter what!
            try
            {
                if (Cache.Get(TOTALUSERCOUNT) == null) Cache.Add(TOTALUSERCOUNT, (Membership.GetAllUsers().Count).ToString(), null, DateTime.Now.AddMinutes(5), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.High, null);
                if (Cache.Get(TOTALUSERSONLINE) == null) Cache.Add(TOTALUSERSONLINE, Membership.GetNumberOfUsersOnline().ToString(), null, DateTime.Now.AddMinutes(5), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.High, null);

                ucOpenIDCountText.Text = Cache.Get(TOTALUSERCOUNT).ToString();
                ucOnlineUserCountText.Text = Cache.Get(TOTALUSERSONLINE).ToString();
            }
            catch {}
        }
    }
}