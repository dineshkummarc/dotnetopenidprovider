using System;
using System.Web.UI.WebControls;
using DotNetOpenId.Extensions;
using DotNetOpenId.Extensions.SimpleRegistration;

namespace DotOrg
{
    public partial class ProfileFields : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region date
                dobDayDropdownlist.Items.Add(String.Empty);
                dobDayDropdownlist.Items.Add(new ListItem("1", GetLocalResourceObject("1").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("2", GetLocalResourceObject("2").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("3", GetLocalResourceObject("3").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("4", GetLocalResourceObject("4").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("5", GetLocalResourceObject("5").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("6", GetLocalResourceObject("6").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("7", GetLocalResourceObject("7").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("8", GetLocalResourceObject("8").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("9", GetLocalResourceObject("9").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("10", GetLocalResourceObject("10").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("11", GetLocalResourceObject("11").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("12", GetLocalResourceObject("12").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("13", GetLocalResourceObject("13").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("14", GetLocalResourceObject("14").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("15", GetLocalResourceObject("15").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("16", GetLocalResourceObject("16").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("17", GetLocalResourceObject("17").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("18", GetLocalResourceObject("18").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("19", GetLocalResourceObject("19").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("20", GetLocalResourceObject("20").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("21", GetLocalResourceObject("21").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("22", GetLocalResourceObject("22").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("23", GetLocalResourceObject("23").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("24", GetLocalResourceObject("24").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("25", GetLocalResourceObject("25").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("26", GetLocalResourceObject("26").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("27", GetLocalResourceObject("27").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("28", GetLocalResourceObject("28").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("29", GetLocalResourceObject("29").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("30", GetLocalResourceObject("30").ToString()));
                dobDayDropdownlist.Items.Add(new ListItem("31", GetLocalResourceObject("31").ToString()));

                dobMonthDropdownlist.Items.Add(String.Empty);
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m1").ToString(), GetLocalResourceObject("mv1").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m2").ToString(), GetLocalResourceObject("mv2").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m3").ToString(), GetLocalResourceObject("mv3").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m4").ToString(), GetLocalResourceObject("mv4").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m5").ToString(), GetLocalResourceObject("mv5").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m6").ToString(), GetLocalResourceObject("mv6").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m7").ToString(), GetLocalResourceObject("mv7").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m8").ToString(), GetLocalResourceObject("mv8").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m9").ToString(), GetLocalResourceObject("mv9").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m10").ToString(), GetLocalResourceObject("mv10").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m11").ToString(), GetLocalResourceObject("mv11").ToString()));
                dobMonthDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("m12").ToString(), GetLocalResourceObject("mv12").ToString()));

                dobYearDropdownlist.Items.Add(String.Empty);
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2009").ToString(), "2009"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2008").ToString(), "2008"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2007").ToString(), "2007"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2006").ToString(), "2006"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2005").ToString(), "2005"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2004").ToString(), "2004"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2003").ToString(), "2003"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2002").ToString(), "2002"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2001").ToString(), "2001"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y2000").ToString(), "2000"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1999").ToString(), "1999"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1998").ToString(), "1998"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1997").ToString(), "1997"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1996").ToString(), "1996"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1995").ToString(), "1995"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1994").ToString(), "1994"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1993").ToString(), "1993"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1992").ToString(), "1992"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1991").ToString(), "1991"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1990").ToString(), "1990"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1989").ToString(), "1989"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1988").ToString(), "1988"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1987").ToString(), "1987"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1986").ToString(), "1986"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1985").ToString(), "1985"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1984").ToString(), "1984"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1983").ToString(), "1983"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1982").ToString(), "1982"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1981").ToString(), "1981"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1980").ToString(), "1980"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1979").ToString(), "1979"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1978").ToString(), "1978"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1977").ToString(), "1977"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1976").ToString(), "1976"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1975").ToString(), "1975"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1974").ToString(), "1974"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1973").ToString(), "1973"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1972").ToString(), "1972"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1971").ToString(), "1971"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1970").ToString(), "1970"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1969").ToString(), "1969"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1968").ToString(), "1968"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1967").ToString(), "1967"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1966").ToString(), "1966"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1965").ToString(), "1965"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1964").ToString(), "1964"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1963").ToString(), "1963"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1962").ToString(), "1962"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1961").ToString(), "1961"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1960").ToString(), "1960"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1959").ToString(), "1959"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1958").ToString(), "1958"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1957").ToString(), "1957"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1956").ToString(), "1956"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1955").ToString(), "1955"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1954").ToString(), "1954"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1953").ToString(), "1953"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1952").ToString(), "1952"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1951").ToString(), "1951"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1950").ToString(), "1950"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1949").ToString(), "1949"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1948").ToString(), "1948"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1947").ToString(), "1947"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1946").ToString(), "1946"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1945").ToString(), "1945"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1944").ToString(), "1944"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1943").ToString(), "1943"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1942").ToString(), "1942"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1941").ToString(), "1941"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1940").ToString(), "1940"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1939").ToString(), "1939"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1938").ToString(), "1938"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1937").ToString(), "1937"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1936").ToString(), "1936"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1935").ToString(), "1935"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1934").ToString(), "1934"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1933").ToString(), "1933"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1932").ToString(), "1932"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1931").ToString(), "1931"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1930").ToString(), "1930"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1929").ToString(), "1929"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1928").ToString(), "1928"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1927").ToString(), "1927"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1926").ToString(), "1926"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1925").ToString(), "1925"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1924").ToString(), "1924"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1923").ToString(), "1923"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1922").ToString(), "1922"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1921").ToString(), "1921"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1920").ToString(), "1920"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1919").ToString(), "1919"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1918").ToString(), "1918"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1917").ToString(), "1917"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1916").ToString(), "1916"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1915").ToString(), "1915"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1914").ToString(), "1914"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1913").ToString(), "1913"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1912").ToString(), "1912"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1911").ToString(), "1911"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1910").ToString(), "1910"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1909").ToString(), "1909"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1908").ToString(), "1908"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1907").ToString(), "1907"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1906").ToString(), "1906"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1905").ToString(), "1905"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1904").ToString(), "1904"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1903").ToString(), "1903"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1902").ToString(), "1902"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1901").ToString(), "1901"));
                dobYearDropdownlist.Items.Add(new ListItem(GetLocalResourceObject("y1900").ToString(), "1900"));
                #endregion

                #region male?
                genderDropdownList.Items.Add(String.Empty);
                genderDropdownList.Items[0].Selected = true;
                genderDropdownList.Items.Add(GetLocalResourceObject("Male").ToString());
                genderDropdownList.Items.Add(GetLocalResourceObject("Female").ToString());
                #endregion

                #region countryDropdownList
                countryDropdownList.Items.Add(String.Empty);
                countryDropdownList.Items[0].Selected = true;
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AF").ToString(), "AF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AX").ToString(), "AX"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AL").ToString(), "AL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("DZ").ToString(), "DZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AS").ToString(), "AS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AD").ToString(), "AD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AO").ToString(), "AO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AI").ToString(), "AI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AQ").ToString(), "AQ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AG").ToString(), "AG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AR").ToString(), "AR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AM").ToString(), "AM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AW").ToString(), "AW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AU").ToString(), "AU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AT").ToString(), "AT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AZ").ToString(), "AZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AF").ToString(), "AF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BS").ToString(), "BS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BH").ToString(), "BH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BD").ToString(), "BD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BB").ToString(), "BB"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BY").ToString(), "BY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BE").ToString(), "BE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BZ").ToString(), "BZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BJ").ToString(), "BJ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BM").ToString(), "BM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BT").ToString(), "BT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BO").ToString(), "BO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BA").ToString(), "BA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BW").ToString(), "BW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BV").ToString(), "BV"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BR").ToString(), "BR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IO").ToString(), "IO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BN").ToString(), "BN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BG").ToString(), "BG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BF").ToString(), "BF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("BI").ToString(), "BI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KH").ToString(), "KH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CM").ToString(), "CM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CA").ToString(), "CA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CV").ToString(), "CV"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KY").ToString(), "KY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CF").ToString(), "CF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TD").ToString(), "TD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CL").ToString(), "CL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CN").ToString(), "CN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CX").ToString(), "CX"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CC").ToString(), "CC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CO").ToString(), "CO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KM").ToString(), "KM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CG").ToString(), "CG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CD").ToString(), "CD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CK").ToString(), "CK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CR").ToString(), "CR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CI").ToString(), "CI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("HR").ToString(), "HR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CU").ToString(), "CU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CY").ToString(), "CY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CZ").ToString(), "CZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("DK").ToString(), "DK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("DJ").ToString(), "DJ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("DM").ToString(), "DM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("DO").ToString(), "DO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("EC").ToString(), "EC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("EG").ToString(), "EG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SV").ToString(), "SV"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GQ").ToString(), "GQ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ER").ToString(), "ER"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("EE").ToString(), "EE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ET").ToString(), "ET"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("FK").ToString(), "FK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("FO").ToString(), "FO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("FJ").ToString(), "FJ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("FI").ToString(), "FI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("FR").ToString(), "FR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GF").ToString(), "GF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PF").ToString(), "PF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TF").ToString(), "TF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GA").ToString(), "GA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GM").ToString(), "GM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GE").ToString(), "GE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("DE").ToString(), "DE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GH").ToString(), "GH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GI").ToString(), "GI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GR").ToString(), "GR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GL").ToString(), "GL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GD").ToString(), "GD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GP").ToString(), "GP"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GU").ToString(), "GU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GT").ToString(), "GT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GG").ToString(), "GG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GN").ToString(), "GN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GW").ToString(), "GW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GY").ToString(), "GY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("HT").ToString(), "HT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("HM").ToString(), "HM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VA").ToString(), "VA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("HN").ToString(), "HN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("HK").ToString(), "HK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("HU").ToString(), "HU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IS").ToString(), "IS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IN").ToString(), "IN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ID").ToString(), "ID"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IR").ToString(), "IR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IQ").ToString(), "IQ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IE").ToString(), "IE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IM").ToString(), "IM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IL").ToString(), "IL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("IT").ToString(), "IT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("JM").ToString(), "JM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("JP").ToString(), "JP"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("JE").ToString(), "JE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("JO").ToString(), "JO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KZ").ToString(), "KZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KE").ToString(), "KE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KI").ToString(), "KI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KP").ToString(), "KP"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KR").ToString(), "KR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KW").ToString(), "KW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KG").ToString(), "KG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LA").ToString(), "LA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LV").ToString(), "LV"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LB").ToString(), "LB"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LS").ToString(), "LS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LR").ToString(), "LR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LY").ToString(), "LY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LI").ToString(), "LI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LT").ToString(), "LT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LU").ToString(), "LU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MO").ToString(), "MO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MK").ToString(), "MK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MG").ToString(), "MG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MW").ToString(), "MW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MY").ToString(), "MY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MV").ToString(), "MV"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ML").ToString(), "ML"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MT").ToString(), "MT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MH").ToString(), "MH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MQ").ToString(), "MQ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MR").ToString(), "MR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MU").ToString(), "MU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("YT").ToString(), "YT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MX").ToString(), "MX"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("FM").ToString(), "FM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MD").ToString(), "MD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MC").ToString(), "MC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MN").ToString(), "MN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ME").ToString(), "ME"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MS").ToString(), "MS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MA").ToString(), "MA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MZ").ToString(), "MZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MM").ToString(), "MM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NA").ToString(), "NA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NR").ToString(), "NR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NP").ToString(), "NP"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NL").ToString(), "NL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AN").ToString(), "AN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NC").ToString(), "NC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NZ").ToString(), "NZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NI").ToString(), "NI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NE").ToString(), "NE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NG").ToString(), "NG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NU").ToString(), "NU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NF").ToString(), "NF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("MP").ToString(), "MP"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("NO").ToString(), "NO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("OM").ToString(), "OM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PK").ToString(), "PK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PW").ToString(), "PW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PS").ToString(), "PS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PA").ToString(), "PA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PG").ToString(), "PG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PY").ToString(), "PY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PE").ToString(), "PE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PH").ToString(), "PH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PN").ToString(), "PN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PL").ToString(), "PL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PT").ToString(), "PT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PR").ToString(), "PR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("QA").ToString(), "QA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("RE").ToString(), "RE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("RO").ToString(), "RO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("RU").ToString(), "RU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("RW").ToString(), "RW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SH").ToString(), "SH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("KN").ToString(), "KN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LC").ToString(), "LC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("PM").ToString(), "PM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VC").ToString(), "VC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("WS").ToString(), "WS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SM").ToString(), "SM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ST").ToString(), "ST"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SA").ToString(), "SA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SN").ToString(), "SN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("RS").ToString(), "RS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SC").ToString(), "SC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SL").ToString(), "SL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SG").ToString(), "SG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SK").ToString(), "SK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SI").ToString(), "SI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SB").ToString(), "SB"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SO").ToString(), "SO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ZA").ToString(), "ZA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GS").ToString(), "GS"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ES").ToString(), "ES"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("LK").ToString(), "LK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SD").ToString(), "SD"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SR").ToString(), "SR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SJ").ToString(), "SJ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SZ").ToString(), "SZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SE").ToString(), "SE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("CH").ToString(), "CH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("SY").ToString(), "SY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TW").ToString(), "TW"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TJ").ToString(), "TJ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TZ").ToString(), "TZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TH").ToString(), "TH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TL").ToString(), "TL"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TG").ToString(), "TG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TK").ToString(), "TK"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TO").ToString(), "TO"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TT").ToString(), "TT"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TN").ToString(), "TN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TR").ToString(), "TR"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TM").ToString(), "TM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TC").ToString(), "TC"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("TV").ToString(), "TV"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("UG").ToString(), "UG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("UA").ToString(), "UA"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("AE").ToString(), "AE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("GB").ToString(), "GB"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("US").ToString(), "US"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("UM").ToString(), "UM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("UY").ToString(), "UY"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("UZ").ToString(), "UZ"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VU").ToString(), "VU"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VE").ToString(), "VE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VN").ToString(), "VN"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VG").ToString(), "VG"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("VI").ToString(), "VI"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("WF").ToString(), "WF"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("EH").ToString(), "EH"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("YE").ToString(), "YE"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ZM").ToString(), "ZM"));
                countryDropdownList.Items.Add(new ListItem(GetLocalResourceObject("ZW").ToString(), "ZW"));
                #endregion

                #region languageDropdownList
                languageDropdownList.Items.Add(String.Empty);
                languageDropdownList.Items[0].Selected = true;
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_EN").ToString(), "EN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AB").ToString(), "AB"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AA").ToString(), "AA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AF").ToString(), "AF"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SQ").ToString(), "SQ"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AM").ToString(), "AM"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AR").ToString(), "AR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_HY").ToString(), "HY"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AS").ToString(), "AS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AY").ToString(), "AY"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_AZ").ToString(), "AZ"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BA").ToString(), "BA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_EU").ToString(), "EU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BN").ToString(), "BN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_DZ").ToString(), "DZ"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BH").ToString(), "BH"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BI").ToString(), "BI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BR").ToString(), "BR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BG").ToString(), "BG"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MY").ToString(), "MY"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BE").ToString(), "BE"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KM").ToString(), "KM"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_CA").ToString(), "CA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_ZH").ToString(), "ZH"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_CO").ToString(), "CO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_HR").ToString(), "HR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_CS").ToString(), "CS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_DA").ToString(), "DA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_NL").ToString(), "NL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_EO").ToString(), "EO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_ET").ToString(), "ET"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_FO").ToString(), "FO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_FJ").ToString(), "FJ"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_FI").ToString(), "FI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_FR").ToString(), "FR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_FY").ToString(), "FY"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_GD").ToString(), "GD"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_GL").ToString(), "GL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KA").ToString(), "KA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_DE").ToString(), "DE"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_EL").ToString(), "EL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KL").ToString(), "KL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_GN").ToString(), "GN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_GU").ToString(), "GU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_HA").ToString(), "HA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IW").ToString(), "IW"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_HI").ToString(), "HI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_HU").ToString(), "HU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IS").ToString(), "IS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IN").ToString(), "IN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IA").ToString(), "IA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IE").ToString(), "IE"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IK").ToString(), "IK"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_GA").ToString(), "GA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_IT").ToString(), "IT"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_JA").ToString(), "JA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_JW").ToString(), "JW"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KN").ToString(), "KN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KS").ToString(), "KS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KK").ToString(), "KK"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_RW").ToString(), "RW"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KY").ToString(), "KY"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_RN").ToString(), "RN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KO").ToString(), "KO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_KU").ToString(), "KU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_LO").ToString(), "LO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_LA").ToString(), "LA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_LV").ToString(), "LV"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_LN").ToString(), "LN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_LT").ToString(), "LT"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MK").ToString(), "MK"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MG").ToString(), "MG"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MS").ToString(), "MS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_ML").ToString(), "ML"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MT").ToString(), "MT"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MI").ToString(), "MI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MR").ToString(), "MR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MO").ToString(), "MO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_MN").ToString(), "MN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_NA").ToString(), "NA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_NE").ToString(), "NE"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_NO").ToString(), "NO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_OC").ToString(), "OC"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_OR").ToString(), "OR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_OM").ToString(), "OM"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_PS").ToString(), "PS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_FA").ToString(), "FA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_PL").ToString(), "PL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_PT").ToString(), "PT"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_PA").ToString(), "PA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_QU").ToString(), "QU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_RM").ToString(), "RM"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_RO").ToString(), "RO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_RU").ToString(), "RU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SM").ToString(), "SM"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SG").ToString(), "SG"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SA").ToString(), "SA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SR").ToString(), "SR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SH").ToString(), "SH"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_ST").ToString(), "ST"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TN").ToString(), "TN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SN").ToString(), "SN"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SD").ToString(), "SD"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SI").ToString(), "SI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SS").ToString(), "SS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SK").ToString(), "SK"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SL").ToString(), "SL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SO").ToString(), "SO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_ES").ToString(), "ES"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SU").ToString(), "SU"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SW").ToString(), "SW"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_SV").ToString(), "SV"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TL").ToString(), "TL"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TG").ToString(), "TG"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TA").ToString(), "TA"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TT").ToString(), "TT"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TE").ToString(), "TE"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TH").ToString(), "TH"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_BO").ToString(), "BO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TI").ToString(), "TI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TO").ToString(), "TO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TS").ToString(), "TS"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TR").ToString(), "TR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TK").ToString(), "TK"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_TW").ToString(), "TW"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_UK").ToString(), "UK"));


                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_UR").ToString(), "UR"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_UZ").ToString(), "UZ"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_VI").ToString(), "VI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_VO").ToString(), "VO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_WO").ToString(), "WO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_XH").ToString(), "XH"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_JI").ToString(), "JI"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_YO").ToString(), "YO"));
                languageDropdownList.Items.Add(new ListItem(GetLocalResourceObject("L_ZU").ToString(), "ZU"));
                #endregion

                #region timezoneDropdownList
                timezoneDropdownList.Items.Add(String.Empty);
                timezoneDropdownList.Items[0].Selected = true;
                timezoneDropdownList.Items.Add(new ListItem("Europe/London", GetLocalResourceObject("Europe/London").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Campo_Grande", GetLocalResourceObject("America/Campo_Grande").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Cambridge_Bay", GetLocalResourceObject("America/Cambridge_Bay").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Boise", GetLocalResourceObject("America/Boise").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Bogota", GetLocalResourceObject("America/Bogota").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Boa_Vista", GetLocalResourceObject("America/Boa_Vista").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Belize", GetLocalResourceObject("America/Belize").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Belem", GetLocalResourceObject("America/Belem").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Barbados", GetLocalResourceObject("America/Barbados").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Bahia", GetLocalResourceObject("America/Bahia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Asuncion", GetLocalResourceObject("America/Asuncion").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Aruba", GetLocalResourceObject("America/Aruba").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Ushuaia", GetLocalResourceObject("America/Argentina/Ushuaia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Tucuman", GetLocalResourceObject("America/Argentina/Tucuman").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/San_Juan", GetLocalResourceObject("America/Argentina/San_Juan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Rio_Gallegos", GetLocalResourceObject("America/Argentina/Rio_Gallegos").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Mendoza", GetLocalResourceObject("America/Argentina/Mendoza").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/La_Rioja", GetLocalResourceObject("America/Argentina/La_Rioja").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Jujuy", GetLocalResourceObject("America/Argentina/Jujuy").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Cordoba", GetLocalResourceObject("America/Argentina/Cordoba").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Catamarca", GetLocalResourceObject("America/Argentina/Catamarca").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Argentina/Buenos_Aires", GetLocalResourceObject("America/Argentina/Buenos_Aires").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Araguaina", GetLocalResourceObject("America/Araguaina").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Antigua", GetLocalResourceObject("America/Antigua").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Anguilla", GetLocalResourceObject("America/Anguilla").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Anchorage", GetLocalResourceObject("America/Anchorage").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Adak", GetLocalResourceObject("America/Adak").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Windhoek", GetLocalResourceObject("Africa/Windhoek").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Tunis", GetLocalResourceObject("Africa/Tunis").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Tripoli", GetLocalResourceObject("Africa/Tripoli").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Sao_Tome", GetLocalResourceObject("Africa/Sao_Tome").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Porto", GetLocalResourceObject("Africa/Porto").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Ouagadougou", GetLocalResourceObject("Africa/Ouagadougou").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Nouakchott", GetLocalResourceObject("Africa/Nouakchott").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Niamey", GetLocalResourceObject("Africa/Niamey").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Ndjamena", GetLocalResourceObject("Africa/Ndjamena").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Nairobi", GetLocalResourceObject("Africa/Nairobi").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Monrovia", GetLocalResourceObject("Africa/Monrovia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Mogadishu", GetLocalResourceObject("Africa/Mogadishu").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Mbabane", GetLocalResourceObject("Africa/Mbabane").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Maseru", GetLocalResourceObject("Africa/Maseru").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Maputo", GetLocalResourceObject("Africa/Maputo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Malabo", GetLocalResourceObject("Africa/Malabo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Lusaka", GetLocalResourceObject("Africa/Lusaka").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Lubumbashi", GetLocalResourceObject("Africa/Lubumbashi").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Lome", GetLocalResourceObject("Africa/Lome").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Libreville", GetLocalResourceObject("Africa/Libreville").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Lagos", GetLocalResourceObject("Africa/Lagos").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Kinshasa", GetLocalResourceObject("Africa/Kinshasa").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Kigali", GetLocalResourceObject("Africa/Kigali").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Khartoum", GetLocalResourceObject("Africa/Khartoum").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Kampala", GetLocalResourceObject("Africa/Kampala").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Johannesburg", GetLocalResourceObject("Africa/Johannesburg").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Harare", GetLocalResourceObject("Africa/Harare").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Gaborone", GetLocalResourceObject("Africa/Gaborone").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Freetown", GetLocalResourceObject("Africa/Freetown").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/El_Aaiun", GetLocalResourceObject("Africa/El_Aaiun").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Douala", GetLocalResourceObject("Africa/Douala").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Djibouti", GetLocalResourceObject("Africa/Djibouti").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Dar_es_Salaam", GetLocalResourceObject("Africa/Dar_es_Salaam").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Dakar", GetLocalResourceObject("Africa/Dakar").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Conakry", GetLocalResourceObject("Africa/Conakry").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Ceuta", GetLocalResourceObject("Africa/Ceuta").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Casablanca", GetLocalResourceObject("Africa/Casablanca").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Cairo", GetLocalResourceObject("Africa/Cairo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Bujumbura", GetLocalResourceObject("Africa/Bujumbura").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Brazzaville", GetLocalResourceObject("Africa/Brazzaville").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Blantyre", GetLocalResourceObject("Africa/Blantyre").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Bissau", GetLocalResourceObject("Africa/Bissau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Banjul", GetLocalResourceObject("Africa/Banjul").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Bangui", GetLocalResourceObject("Africa/Bangui").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Bamako", GetLocalResourceObject("Africa/Bamako").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Asmera", GetLocalResourceObject("Africa/Asmera").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Algiers", GetLocalResourceObject("Africa/Algiers").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Addis_Ababa", GetLocalResourceObject("Africa/Addis_Ababa").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Accra", GetLocalResourceObject("Africa/Accra").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Abidjan", GetLocalResourceObject("Africa/Abidjan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/London", GetLocalResourceObject("Europe/London").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Cancun", GetLocalResourceObject("America/Cancun").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Caracas", GetLocalResourceObject("America/Caracas").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Cayenne", GetLocalResourceObject("America/Cayenne").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Cayman", GetLocalResourceObject("America/Cayman").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Chicago", GetLocalResourceObject("America/Chicago").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Chihuahua", GetLocalResourceObject("America/Chihuahua").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Coral_Harbour", GetLocalResourceObject("America/Coral_Harbour").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Costa_Rica", GetLocalResourceObject("America/Costa_Rica").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Cuiaba", GetLocalResourceObject("America/Cuiaba").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Curacao", GetLocalResourceObject("America/Curacao").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Africa/Bangui", GetLocalResourceObject("Africa/Bangui").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Danmarkshavn", GetLocalResourceObject("America/Danmarkshavn").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Dawson", GetLocalResourceObject("America/Dawson").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Dawson_Creek", GetLocalResourceObject("America/Dawson_Creek").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Denver", GetLocalResourceObject("America/Denver").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Detroit", GetLocalResourceObject("America/Detroit").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Dominica", GetLocalResourceObject("America/Dominica").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Edmonton", GetLocalResourceObject("America/Edmonton").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Eirunepe", GetLocalResourceObject("America/Eirunepe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/El_Salvador", GetLocalResourceObject("America/El_Salvador").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Fortaleza", GetLocalResourceObject("America/Fortaleza").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Glace_Bay", GetLocalResourceObject("America/Glace_Bay").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Godthab", GetLocalResourceObject("America/Godthab").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Goose_Bay", GetLocalResourceObject("America/Goose_Bay").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Grand_Turk", GetLocalResourceObject("America/Grand_Turk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Grenada", GetLocalResourceObject("America/Grenada").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Guadeloupe", GetLocalResourceObject("America/Guadeloupe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Guatemala", GetLocalResourceObject("America/Guatemala").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Guayaquil", GetLocalResourceObject("America/Guayaquil").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Guyana", GetLocalResourceObject("America/Guyana").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Halifax", GetLocalResourceObject("America/Halifax").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Havana", GetLocalResourceObject("America/Havana").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Hermosillo", GetLocalResourceObject("America/Hermosillo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Indiana/Indianapolis", GetLocalResourceObject("America/Indiana/Indianapolis").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Indiana/Knox", GetLocalResourceObject("America/Indiana/Knox").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Indiana/Marengo", GetLocalResourceObject("America/Indiana/Marengo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Indiana/Petersburg", GetLocalResourceObject("America/Indiana/Petersburg").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Indiana/Vevay", GetLocalResourceObject("America/Indiana/Vevay").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Indiana/Vincennes", GetLocalResourceObject("America/Indiana/Vincennes").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Inuvik", GetLocalResourceObject("America/Inuvik").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Iqaluit", GetLocalResourceObject("America/Iqaluit").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Jamaica", GetLocalResourceObject("America/Jamaica").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Juneau", GetLocalResourceObject("America/Juneau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Kentucky/Louisville", GetLocalResourceObject("America/Kentucky/Louisville").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Kentucky/Monticello", GetLocalResourceObject("America/Kentucky/Monticello").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/La_Paz", GetLocalResourceObject("America/La_Paz").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Lima", GetLocalResourceObject("America/Lima").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Los_Angeles", GetLocalResourceObject("America/Los_Angeles").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Maceio", GetLocalResourceObject("America/Maceio").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Managua", GetLocalResourceObject("America/Managua").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Manaus", GetLocalResourceObject("America/Manaus").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Martinique", GetLocalResourceObject("America/Martinique").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Mazatlan", GetLocalResourceObject("America/Mazatlan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Menominee", GetLocalResourceObject("America/Menominee").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Merida", GetLocalResourceObject("America/Merida").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Mexico_City", GetLocalResourceObject("America/Mexico_City").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Miquelon", GetLocalResourceObject("America/Miquelon").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Moncton", GetLocalResourceObject("America/Moncton").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Monterrey", GetLocalResourceObject("America/Monterrey").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Montevideo", GetLocalResourceObject("America/Montevideo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Montreal", GetLocalResourceObject("America/Montreal").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Montserrat", GetLocalResourceObject("America/Montserrat").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Nassau", GetLocalResourceObject("America/Nassau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/New_York", GetLocalResourceObject("America/New_York").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Nipigon", GetLocalResourceObject("America/Nipigon").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Nome", GetLocalResourceObject("America/Nome").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Noronha", GetLocalResourceObject("America/Noronha").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/North_Dakota/Center", GetLocalResourceObject("America/North_Dakota/Center").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Panama", GetLocalResourceObject("America/Panama").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Pangnirtung", GetLocalResourceObject("America/Pangnirtung").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Paramaribo", GetLocalResourceObject("America/Paramaribo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Phoenix", GetLocalResourceObject("America/Phoenix").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Port", GetLocalResourceObject("America/Port").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Port_of_Spain", GetLocalResourceObject("America/Port_of_Spain").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Porto_Velho", GetLocalResourceObject("America/Porto_Velho").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Puerto_Rico", GetLocalResourceObject("America/Puerto_Rico").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Rainy_River", GetLocalResourceObject("America/Rainy_River").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Rankin_Inlet", GetLocalResourceObject("America/Rankin_Inlet").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Recife", GetLocalResourceObject("America/Recife").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Regina", GetLocalResourceObject("America/Regina").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Rio_Branco", GetLocalResourceObject("America/Rio_Branco").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Santiago", GetLocalResourceObject("America/Santiago").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Santo_Domingo", GetLocalResourceObject("America/Santo_Domingo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Sao_Paulo", GetLocalResourceObject("America/Sao_Paulo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Scoresbysund", GetLocalResourceObject("America/Scoresbysund").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Shiprock", GetLocalResourceObject("America/Shiprock").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/St_Johns", GetLocalResourceObject("America/St_Johns").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/St_Kitts", GetLocalResourceObject("America/St_Kitts").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/St_Lucia", GetLocalResourceObject("America/St_Lucia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/St_Thomas", GetLocalResourceObject("America/St_Thomas").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/St_Vincent", GetLocalResourceObject("America/St_Vincent").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Swift_Current", GetLocalResourceObject("America/Swift_Current").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Tegucigalpa", GetLocalResourceObject("America/Tegucigalpa").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Thule", GetLocalResourceObject("America/Thule").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Thunder_Bay", GetLocalResourceObject("America/Thunder_Bay").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Tijuana", GetLocalResourceObject("America/Tijuana").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Toronto", GetLocalResourceObject("America/Toronto").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Tortola", GetLocalResourceObject("America/Tortola").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Vancouver", GetLocalResourceObject("America/Vancouver").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Whitehorse", GetLocalResourceObject("America/Whitehorse").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Winnipeg", GetLocalResourceObject("America/Winnipeg").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Yakutat", GetLocalResourceObject("America/Yakutat").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("America/Yellowknife", GetLocalResourceObject("America/Yellowknife").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Casey", GetLocalResourceObject("Antarctica/Casey").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Davis", GetLocalResourceObject("Antarctica/Davis").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/DumontDUrville", GetLocalResourceObject("Antarctica/DumontDUrville").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Mawson", GetLocalResourceObject("Antarctica/Mawson").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/McMurdo", GetLocalResourceObject("Antarctica/McMurdo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Palmer", GetLocalResourceObject("Antarctica/Palmer").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Rothera", GetLocalResourceObject("Antarctica/Rothera").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/South_Pole", GetLocalResourceObject("Antarctica/South_Pole").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Syowa", GetLocalResourceObject("Antarctica/Syowa").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Antarctica/Vostok", GetLocalResourceObject("Antarctica/Vostok").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Arctic/Longyearbyen", GetLocalResourceObject("Arctic/Longyearbyen").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Aden", GetLocalResourceObject("Asia/Aden").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Almaty", GetLocalResourceObject("Asia/Almaty").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Amman", GetLocalResourceObject("Asia/Amman").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Anadyr", GetLocalResourceObject("Asia/Anadyr").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Aqtau", GetLocalResourceObject("Asia/Aqtau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Aqtobe", GetLocalResourceObject("Asia/Aqtobe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Ashgabat", GetLocalResourceObject("Asia/Ashgabat").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Baghdad", GetLocalResourceObject("Asia/Baghdad").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Bahrain", GetLocalResourceObject("Asia/Bahrain").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Baku", GetLocalResourceObject("Asia/Baku").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Bangkok", GetLocalResourceObject("Asia/Bangkok").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Beirut", GetLocalResourceObject("Asia/Beirut").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Bishkek", GetLocalResourceObject("Asia/Bishkek").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Brunei", GetLocalResourceObject("Asia/Brunei").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Calcutta", GetLocalResourceObject("Asia/Calcutta").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Choibalsan", GetLocalResourceObject("Asia/Choibalsan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Chongqing", GetLocalResourceObject("Asia/Chongqing").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Colombo", GetLocalResourceObject("Asia/Colombo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Damascus", GetLocalResourceObject("Asia/Damascus").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Dhaka", GetLocalResourceObject("Asia/Dhaka").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Dili", GetLocalResourceObject("Asia/Dili").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Dubai", GetLocalResourceObject("Asia/Dubai").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Dushanbe", GetLocalResourceObject("Asia/Dushanbe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Gaza", GetLocalResourceObject("Asia/Gaza").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Harbin", GetLocalResourceObject("Asia/Harbin").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Hong_Kong", GetLocalResourceObject("Asia/Hong_Kong").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Hovd", GetLocalResourceObject("Asia/Hovd").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Irkutsk", GetLocalResourceObject("Asia/Irkutsk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Jakarta", GetLocalResourceObject("Asia/Jakarta").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Jayapura", GetLocalResourceObject("Asia/Jayapura").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Jerusalem", GetLocalResourceObject("Asia/Jerusalem").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Kabul", GetLocalResourceObject("Asia/Kabul").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Kamchatka", GetLocalResourceObject("Asia/Kamchatka").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Karachi", GetLocalResourceObject("Asia/Karachi").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Kashgar", GetLocalResourceObject("Asia/Kashgar").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Katmandu", GetLocalResourceObject("Asia/Katmandu").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Krasnoyarsk", GetLocalResourceObject("Asia/Krasnoyarsk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Kuala_Lumpur", GetLocalResourceObject("Asia/Kuala_Lumpur").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Kuching", GetLocalResourceObject("Asia/Kuching").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Kuwait", GetLocalResourceObject("Asia/Kuwait").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Macau", GetLocalResourceObject("Asia/Macau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Magadan", GetLocalResourceObject("Asia/Magadan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Makassar", GetLocalResourceObject("Asia/Makassar").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Manila", GetLocalResourceObject("Asia/Manila").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Muscat", GetLocalResourceObject("Asia/Muscat").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Nicosia", GetLocalResourceObject("Asia/Nicosia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Novosibirsk", GetLocalResourceObject("Asia/Novosibirsk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Omsk", GetLocalResourceObject("Asia/Omsk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Oral", GetLocalResourceObject("Asia/Oral").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Phnom_Penh", GetLocalResourceObject("Asia/Phnom_Penh").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Pontianak", GetLocalResourceObject("Asia/Pontianak").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Pyongyang", GetLocalResourceObject("Asia/Pyongyang").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Qatar", GetLocalResourceObject("Asia/Qatar").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Qyzylorda", GetLocalResourceObject("Asia/Qyzylorda").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Rangoon", GetLocalResourceObject("Asia/Rangoon").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Riyadh", GetLocalResourceObject("Asia/Riyadh").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Saigon", GetLocalResourceObject("Asia/Saigon").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Sakhalin", GetLocalResourceObject("Asia/Sakhalin").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Samarkand", GetLocalResourceObject("Asia/Samarkand").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Seoul", GetLocalResourceObject("Asia/Seoul").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Shanghai", GetLocalResourceObject("Asia/Shanghai").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Singapore", GetLocalResourceObject("Asia/Singapore").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Taipei", GetLocalResourceObject("Asia/Taipei").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Tashkent", GetLocalResourceObject("Asia/Tashkent").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Tbilisi", GetLocalResourceObject("Asia/Tbilisi").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Tehran", GetLocalResourceObject("Asia/Tehran").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Thimphu", GetLocalResourceObject("Asia/Thimphu").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Tokyo", GetLocalResourceObject("Asia/Tokyo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Ulaanbaatar", GetLocalResourceObject("Asia/Ulaanbaatar").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Urumqi", GetLocalResourceObject("Asia/Urumqi").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Vientiane", GetLocalResourceObject("Asia/Vientiane").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Vladivostok", GetLocalResourceObject("Asia/Vladivostok").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Yakutsk", GetLocalResourceObject("Asia/Yakutsk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Yekaterinburg", GetLocalResourceObject("Asia/Yekaterinburg").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Asia/Yerevan", GetLocalResourceObject("Asia/Yerevan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Azores", GetLocalResourceObject("Atlantic/Azores").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Bermuda", GetLocalResourceObject("Atlantic/Bermuda").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Canary", GetLocalResourceObject("Atlantic/Canary").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Cape_Verde", GetLocalResourceObject("Atlantic/Cape_Verde").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Faeroe", GetLocalResourceObject("Atlantic/Faeroe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Jan_Mayen", GetLocalResourceObject("Atlantic/Jan_Mayen").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Madeira", GetLocalResourceObject("Atlantic/Madeira").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Reykjavik", GetLocalResourceObject("Atlantic/Reykjavik").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/South_Georgia", GetLocalResourceObject("Atlantic/South_Georgia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/St_Helena", GetLocalResourceObject("Atlantic/St_Helena").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Atlantic/Stanley", GetLocalResourceObject("Atlantic/Stanley").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Adelaide", GetLocalResourceObject("Australia/Adelaide").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Brisbane", GetLocalResourceObject("Australia/Brisbane").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Broken_Hill", GetLocalResourceObject("Australia/Broken_Hill").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Currie", GetLocalResourceObject("Australia/Currie").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Darwin", GetLocalResourceObject("Australia/Darwin").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Hobart", GetLocalResourceObject("Australia/Hobart").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Lindeman", GetLocalResourceObject("Australia/Lindeman").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Lord_Howe", GetLocalResourceObject("Australia/Lord_Howe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Melbourne", GetLocalResourceObject("Australia/Melbourne").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Perth", GetLocalResourceObject("Australia/Perth").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Australia/Sydney", GetLocalResourceObject("Australia/Sydney").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Amsterdam", GetLocalResourceObject("Europe/Amsterdam").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Andorra", GetLocalResourceObject("Europe/Andorra").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Athens", GetLocalResourceObject("Europe/Athens").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Belgrade", GetLocalResourceObject("Europe/Belgrade").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Berlin", GetLocalResourceObject("Europe/Berlin").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Bratislava", GetLocalResourceObject("Europe/Bratislava").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Brussels", GetLocalResourceObject("Europe/Brussels").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Bucharest", GetLocalResourceObject("Europe/Bucharest").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Budapest", GetLocalResourceObject("Europe/Budapest").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Chisinau", GetLocalResourceObject("Europe/Chisinau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Copenhagen", GetLocalResourceObject("Europe/Copenhagen").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Dublin", GetLocalResourceObject("Europe/Dublin").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Gibraltar", GetLocalResourceObject("Europe/Gibraltar").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Helsinki", GetLocalResourceObject("Europe/Helsinki").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Istanbul", GetLocalResourceObject("Europe/Istanbul").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Kaliningrad", GetLocalResourceObject("Europe/Kaliningrad").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Kiev", GetLocalResourceObject("Europe/Kiev").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Lisbon", GetLocalResourceObject("Europe/Lisbon").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Ljubljana", GetLocalResourceObject("Europe/Ljubljana").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Luxembourg", GetLocalResourceObject("Europe/Luxembourg").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Madrid", GetLocalResourceObject("Europe/Madrid").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Malta", GetLocalResourceObject("Europe/Malta").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Mariehamn", GetLocalResourceObject("Europe/Mariehamn").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Minsk", GetLocalResourceObject("Europe/Minsk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Monaco", GetLocalResourceObject("Europe/Monaco").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Moscow", GetLocalResourceObject("Europe/Moscow").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Oslo", GetLocalResourceObject("Europe/Oslo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Paris", GetLocalResourceObject("Europe/Paris").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Prague", GetLocalResourceObject("Europe/Prague").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Riga", GetLocalResourceObject("Europe/Riga").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Rome", GetLocalResourceObject("Europe/Rome").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Samara", GetLocalResourceObject("Europe/Samara").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/San_Marino", GetLocalResourceObject("Europe/San_Marino").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Sarajevo", GetLocalResourceObject("Europe/Sarajevo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Simferopol", GetLocalResourceObject("Europe/Simferopol").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Skopje", GetLocalResourceObject("Europe/Skopje").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Sofia", GetLocalResourceObject("Europe/Sofia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Stockholm", GetLocalResourceObject("Europe/Stockholm").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Tallinn", GetLocalResourceObject("Europe/Tallinn").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Tirane", GetLocalResourceObject("Europe/Tirane").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Uzhgorod", GetLocalResourceObject("Europe/Uzhgorod").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Vaduz", GetLocalResourceObject("Europe/Vaduz").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Vatican", GetLocalResourceObject("Europe/Vatican").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Vienna", GetLocalResourceObject("Europe/Vienna").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Vilnius", GetLocalResourceObject("Europe/Vilnius").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Warsaw", GetLocalResourceObject("Europe/Warsaw").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Zagreb", GetLocalResourceObject("Europe/Zagreb").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Zaporozhye", GetLocalResourceObject("Europe/Zaporozhye").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Europe/Zurich", GetLocalResourceObject("Europe/Zurich").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Antananarivo", GetLocalResourceObject("Indian/Antananarivo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Chagos", GetLocalResourceObject("Indian/Chagos").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Christmas", GetLocalResourceObject("Indian/Christmas").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Cocos", GetLocalResourceObject("Indian/Cocos").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Comoro", GetLocalResourceObject("Indian/Comoro").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Kerguelen", GetLocalResourceObject("Indian/Kerguelen").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Mahe", GetLocalResourceObject("Indian/Mahe").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Maldives", GetLocalResourceObject("Indian/Maldives").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Mauritius", GetLocalResourceObject("Indian/Mauritius").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Mayotte", GetLocalResourceObject("Indian/Mayotte").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Indian/Reunion", GetLocalResourceObject("Indian/Reunion").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Apia", GetLocalResourceObject("Pacific/Apia").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Auckland", GetLocalResourceObject("Pacific/Auckland").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Chatham", GetLocalResourceObject("Pacific/Chatham").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Easter", GetLocalResourceObject("Pacific/Easter").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Efate", GetLocalResourceObject("Pacific/Efate").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Enderbury", GetLocalResourceObject("Pacific/Enderbury").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Fakaofo", GetLocalResourceObject("Pacific/Fakaofo").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Fiji", GetLocalResourceObject("Pacific/Fiji").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Funafuti", GetLocalResourceObject("Pacific/Funafuti").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Galapagos", GetLocalResourceObject("Pacific/Galapagos").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Gambier", GetLocalResourceObject("Pacific/Gambier").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Guadalcanal", GetLocalResourceObject("Pacific/Guadalcanal").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Guam", GetLocalResourceObject("Pacific/Guam").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Honolulu", GetLocalResourceObject("Pacific/Honolulu").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Kiritimati", GetLocalResourceObject("Pacific/Kiritimati").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Kosrae", GetLocalResourceObject("Pacific/Kosrae").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Kwajalein", GetLocalResourceObject("Pacific/Kwajalein").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Majuro", GetLocalResourceObject("Pacific/Majuro").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Marquesas", GetLocalResourceObject("Pacific/Marquesas").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Midway", GetLocalResourceObject("Pacific/Midway").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Nauru", GetLocalResourceObject("Pacific/Nauru").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Niue", GetLocalResourceObject("Pacific/Niue").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Norfolk", GetLocalResourceObject("Pacific/Norfolk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Noumea", GetLocalResourceObject("Pacific/Noumea").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Pago_Pago", GetLocalResourceObject("Pacific/Pago_Pago").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Palau", GetLocalResourceObject("Pacific/Palau").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Pitcairn", GetLocalResourceObject("Pacific/Pitcairn").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Ponape", GetLocalResourceObject("Pacific/Ponape").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Port_Moresby", GetLocalResourceObject("Pacific/Port_Moresby").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Rarotonga", GetLocalResourceObject("Pacific/Rarotonga").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Saipan", GetLocalResourceObject("Pacific/Saipan").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Tahiti", GetLocalResourceObject("Pacific/Tahiti").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Tarawa", GetLocalResourceObject("Pacific/Tarawa").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Tongatapu", GetLocalResourceObject("Pacific/Tongatapu").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Truk", GetLocalResourceObject("Pacific/Truk").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Wake", GetLocalResourceObject("Pacific/Wake").ToString()));
                timezoneDropdownList.Items.Add(new ListItem("Pacific/Wallis", GetLocalResourceObject("Pacific/Wallis").ToString()));
                #endregion
            }
        }

        public void SetRequiredFieldsFromRequest(ClaimsRequest requestFields)
        {
            if (requestFields.PolicyUrl != null)
            {
                privacyLink.NavigateUrl = requestFields.PolicyUrl.AbsoluteUri;
            }
            else
            {
                privacyLink.Visible = false;
            }

            dobRequiredLabel.Visible = (requestFields.BirthDate == DemandLevel.Require);
            countryRequiredLabel.Visible = (requestFields.Country == DemandLevel.Require);
            emailRequiredLabel.Visible = (requestFields.Email == DemandLevel.Require);
            fullnameRequiredLabel.Visible = (requestFields.FullName == DemandLevel.Require);
            genderRequiredLabel.Visible = (requestFields.Gender == DemandLevel.Require);
            languageRequiredLabel.Visible = (requestFields.Language == DemandLevel.Require);
            nicknameRequiredLabel.Visible = (requestFields.Nickname == DemandLevel.Require);
            postcodeRequiredLabel.Visible = (requestFields.PostalCode == DemandLevel.Require);
            timezoneRequiredLabel.Visible = (requestFields.TimeZone == DemandLevel.Require);

            dateOfBirthRow.Visible = !(requestFields.BirthDate == DemandLevel.NoRequest);
            countryRow.Visible = !(requestFields.Country == DemandLevel.NoRequest);
            emailRow.Visible = !(requestFields.Email == DemandLevel.NoRequest);
            fullnameRow.Visible = !(requestFields.FullName == DemandLevel.NoRequest);
            genderRow.Visible = !(requestFields.Gender == DemandLevel.NoRequest);
            languageRow.Visible = !(requestFields.Language == DemandLevel.NoRequest);
            nicknameRow.Visible = !(requestFields.Nickname == DemandLevel.NoRequest);
            postcodeRow.Visible = !(requestFields.PostalCode == DemandLevel.NoRequest);
            timezoneRow.Visible = !(requestFields.TimeZone == DemandLevel.NoRequest);
        }

        public bool DoesAnyFieldHaveAValue
        {
            get
            {
                return !((DateOfBirth == null)
                && String.IsNullOrEmpty(countryDropdownList.SelectedValue)
                && String.IsNullOrEmpty(emailTextBox.Text)
                && String.IsNullOrEmpty(fullnameTextBox.Text)
                && (Gender == null)
                && String.IsNullOrEmpty(languageDropdownList.SelectedValue)
                && String.IsNullOrEmpty(nicknameTextBox.Text)
                && String.IsNullOrEmpty(postcodeTextBox.Text)
                && String.IsNullOrEmpty(timezoneDropdownList.SelectedValue));
            }
        }

        public DateTime? DateOfBirth
        {
            get
            {
                try
                {
                    int day = Convert.ToInt32(dobDayDropdownlist.SelectedValue);
                    int month = Convert.ToInt32(dobMonthDropdownlist.SelectedValue);
                    int year = Convert.ToInt32(dobYearDropdownlist.SelectedValue);
                    DateTime newDate = new DateTime(year, month, day);
                    return newDate;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue)
                {
                    dobDayDropdownlist.SelectedValue = value.Value.Day.ToString();
                    dobMonthDropdownlist.SelectedValue = value.Value.Month.ToString();
                    dobYearDropdownlist.SelectedValue = value.Value.Year.ToString();
                }
                else
                {
                    dobDayDropdownlist.SelectedValue = string.Empty;
                    dobMonthDropdownlist.SelectedValue = string.Empty;
                    dobYearDropdownlist.SelectedValue = string.Empty;
                }
            }
        }

        public Gender? Gender
        {
            get
            {
                if (this.genderDropdownList.SelectedValue == "Male")
                {
                    return DotNetOpenId.Extensions.SimpleRegistration.Gender.Male;
                }
                if (this.genderDropdownList.SelectedValue == "Female")
                {
                    return DotNetOpenId.Extensions.SimpleRegistration.Gender.Female;
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    genderDropdownList.SelectedValue = value.Value.ToString();
                }
                else
                {
                    genderDropdownList.SelectedIndex = -1;
                }
            }
        }

        public ClaimsResponse OpenIdProfileFields
        {
            get
            {
                ClaimsResponse fields = new ClaimsResponse();
                fields.BirthDate = DateOfBirth;
                fields.Country = countryDropdownList.SelectedValue;
                fields.Email = emailTextBox.Text;
                fields.FullName = fullnameTextBox.Text;
                fields.Gender = Gender;
                fields.Language = languageDropdownList.SelectedValue;
                fields.Nickname = nicknameTextBox.Text;
                fields.PostalCode = postcodeTextBox.Text;
                fields.TimeZone = timezoneDropdownList.SelectedValue;
                return fields;
            }
            set
            {
                DateOfBirth = value.BirthDate;
                countryDropdownList.SelectedValue = value.Country;
                emailTextBox.Text = value.Email;
                fullnameTextBox.Text = value.FullName;
                Gender = value.Gender;
                languageDropdownList.SelectedValue = value.Language;
                nicknameTextBox.Text = value.Nickname;
                postcodeTextBox.Text = value.PostalCode;
                timezoneDropdownList.SelectedValue = value.TimeZone;
            }
        }
    }
}