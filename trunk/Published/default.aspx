<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.Master" meta:resourcekey="Default" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DotOrg._default" %>
<%@ Import Namespace="DotNetOpenId.Provider" %>
<%@ Register Assembly="DotNetOpenId" Namespace="DotNetOpenId" TagPrefix="openid" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <div style="float:left;"><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div style="float:left;font-size:small;padding-left:20px;"><asp:HyperLink id="ucOfficialSiteLink" runat="server" NavigateUrl="http://openid.net" target="_blank" meta:ResourceKey="ucOfficialSiteLink" /><br />
            <asp:HyperLink id="ucWhatIsLink" runat="server" NavigateUrl="http://openid.net/what/" target="_blank" meta:ResourceKey="ucWhatIsLink" /></div>        
    </div>
    <div style="margin-top:40px;"><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
    <div class="MainOpenIDBox">
        <div><asp:HyperLink ID="ucGetAnOpenID" runat="server" NavigateUrl="register.aspx" class="LabelOpenTitle" meta:ResourceKey="ucGetAnOpenID"></asp:HyperLink></div>
        <br />
        <div style="margin-left:25px;margin-right:25px;"><asp:Label ID="ucOpenIDStyle" runat="server" class="Label" meta:ResourceKey="ucOpenIDStyle"></asp:Label></div>
        <br />
        <div><asp:HyperLink Font-Underline="true" ID="ucLoginWithOpenID" runat="server" NavigateUrl="login.aspx" class="LabelOpenSubTitle" meta:ResourceKey="ucLoginWithOpenID" Visible="false"></asp:HyperLink></div>
    </div>
</asp:Content>