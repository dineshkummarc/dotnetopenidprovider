using System.Configuration;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System;
using System.Web;
using System.Xml;

// nicked from http://www.codeproject.com/aspnet/URLRewriter.asp
namespace DotOrg {
	public class URLRewriter : IConfigurationSectionHandler {
		protected XmlNode _oRules = null;

		protected URLRewriter() { }

        /// <summary>
        /// Excludes files that are not users from the redirect!
        /// </summary>
        /// <param name="zPath"></param>
        /// <returns></returns>
        bool IsExcluded(bool checkRoot, string zPath)
        {
            if ((checkRoot && zPath == "/") || zPath.EndsWith(".axd")) return true;  //catches the root page with no file specified

            return System.IO.File.Exists(HttpContext.Current.Server.MapPath(zPath));
        }

		public string GetSubstitution(string zPath) {
			Regex oReg;
            
            //Only do this if we allow user.domain.com
            if (Boolean.Parse(System.Configuration.ConfigurationManager.AppSettings["EnableSubDomain"]))
            {
                string username = Util.GetUserName(HttpContext.Current.Request.Url.ToString());

                if (username != System.Configuration.ConfigurationManager.AppSettings["OpenIDDomain"])
                {
                    //if we are excluding some path from a redirect then ignore here.
                    if (IsExcluded(false, zPath))
                    {
                        return null;
                    }

                    return username;
                }
            }

            //if we are excluding some path from a redirect then ignore here.
            if (IsExcluded(true, zPath)) return null;

			foreach (XmlNode oNode in _oRules.SelectNodes("rule")) {
				// get the url and rewrite nodes
				XmlNode oUrlNode = oNode.SelectSingleNode("url");
				XmlNode oRewriteNode = oNode.SelectSingleNode("rewrite");

				// check validity of the values
				if (oUrlNode == null || string.IsNullOrEmpty(oUrlNode.InnerText)
					|| oRewriteNode == null || string.IsNullOrEmpty(oRewriteNode.InnerText)) {
					Trace.TraceWarning("Invalid urlrewrites rule discovered in web.config file.");
					continue;
				}

				oReg = new Regex(oUrlNode.InnerText, RegexOptions.IgnoreCase);

				// if match, return the substitution
				Match oMatch = oReg.Match(zPath);
				if (oMatch.Success) {
					return oReg.Replace(zPath, oRewriteNode.InnerText);
				}
			}

			return null; // no rewrite
		}

		public static void Process() {
			URLRewriter oRewriter = (URLRewriter)System.Configuration.ConfigurationManager.GetSection("urlrewrites");

			string zSubst = oRewriter.GetSubstitution(HttpContext.Current.Request.Path);

			if (!string.IsNullOrEmpty(zSubst)) {
				Trace.TraceInformation("Rewriting url '{0}' to '{1}' ", HttpContext.Current.Request.Path, zSubst);
				HttpContext.Current.RewritePath(zSubst);
			}
		}

		#region Implementation of IConfigurationSectionHandler
		public object Create(object parent, object configContext, XmlNode section) {
			_oRules = section;

			return this;
		}
		#endregion
	}
}