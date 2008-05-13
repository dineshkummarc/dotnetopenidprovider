using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Web;
using DotNetOpenId.Provider;
using DotOrg;
using DotNetOpenId;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for Util
/// </summary>
public class Util {
	public static string ExtractUserName(Uri url) {

        //Only do this if we allow user.domain.com
        if (Boolean.Parse(System.Configuration.ConfigurationManager.AppSettings["EnableSubDomain"]))
        {
            string username = Util.GetUserName(url.ToString());

            if (username != System.Configuration.ConfigurationManager.AppSettings["OpenIDDomain"])
                return username.Replace("/user.aspx?username=", String.Empty);
            else
                return url.Segments[url.Segments.Length - 1];
        }
        else
            return url.Segments[url.Segments.Length - 1];
	}
	public static string ExtractUserName(Identifier identifier) {
		return ExtractUserName(new Uri(identifier.ToString()));
	}
	public static Identifier BuildIdentityUrl() {
		return new Uri(HttpContext.Current.Request.Url, HttpContext.Current.User.Identity.Name);
	}

    /// <summary>
    /// If we are using user.domain.org then this gets the user!
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string GetUserName(string url)
    {
        string origUrl = url;

        // IF THERE, REMOVE WHITE SPACE FROM BOTH ENDS
        url = Regex.Replace(url, "^\\s+", String.Empty, RegexOptions.IgnoreCase); // START
        url = Regex.Replace(url, "\\s+$", String.Empty, RegexOptions.IgnoreCase); // END

        ////// IF FOUND, CONVERT BACK SLASHES TO FORWARD SLASHES
        url = Regex.Replace(url, "\\\\", "/", RegexOptions.IgnoreCase); // END

        ////// IF THERE, REMOVES 'http://', 'https://' or 'ftp://' FROM THE START
        url = Regex.Replace(url, "^http\\:\\/\\/|^https\\:\\/\\/|^ftp\\:\\//i", "", RegexOptions.IgnoreCase); // END

        ////// IF THERE, REMOVES 'www.' FROM THE START OF THE STRING
        url = Regex.Replace(url, "^www\\.", "", RegexOptions.IgnoreCase); // END

        //// REMOVE COMPLETE STRING FROM FIRST FORWARD SLASH ON
        url = Regex.Replace(url, "\\/(.*)", "", RegexOptions.IgnoreCase); // END

        ///Regex oReg = new Regex("(.*)." + HttpContext.Current.Request.Url.Authority, RegexOptions.IgnoreCase);
        Regex oReg = new Regex("(.*)." + System.Configuration.ConfigurationManager.AppSettings["OpenIDDomain"], RegexOptions.IgnoreCase);
        Match oMatch = oReg.Match(url);

        if (oMatch.Success)
        {
            return oReg.Replace(url, "/user.aspx?username=$1");
        }

        return (url);

    }
}
