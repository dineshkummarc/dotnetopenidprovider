Release Date - 13 May 2008

Contact
=======
Contact Steven Livingstone-Perez at weblivz AT hotmail.com for further details on this project.

You can see a live version of this portal at http://openid.org

Get the latest version of the library at http://code.google.com/p/dotnetopenid/ - thanks to all the guys there for creating a great library !!

Configuration
=============
1. Optionally restore the ASPNETDB.zip to a database (typically ASPNETDB) provided with the solution. You can alternatively use the OpenID.bak.zip which contains the same database as a backup.

2. Set the "mailSettings" section in the web.config.

3. Set the "OpenIDConnectionString" settings for your database in the web.config.

4. Set the "EmailAdmin" key from whom all emails will be sent.

5. Set the "OpenIDDomain" to define your DOMAIN.COM (most useful when allowing user.domain.org).

6. Set the "EnableSubDomain" if you wish to also allow user.domain.org (the default is domain.org/user).

7. Set the "AspNetSqlMembershipProvider" for your datastore.

Support  (as of 13 May 2008)
=============================
The following sites has been successfully tested:

http://www.livejournal.com
http://zooomr.com
http://www.dasregistry.org/
http://www.jabber.org/
http://www.dopplr.com
http://suggest.commoncraft.com

There are possible issues with the following sites:
http://www.ipernity.com/

There are known issues with the following sites:
http://openiddirectory.com (OpenID authentication failed: Bad signature)
http://wikitravel.org (logs in ok, but fails to receive data)
http://www.egofolio.com/ (logs in, but fails in receieving data Login Error: Bad signature)
http://popurls.net/user/ (authentication failed)
http://www.wetpaintcentral.com (Drat! We encountered a problem with OpenID.)	