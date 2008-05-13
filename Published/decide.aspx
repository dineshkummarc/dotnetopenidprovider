<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="Decide" CodeBehind="decide.aspx.cs" Inherits="DotOrg.decide"%>
<%@ Register Src="ProfileFields.ascx" TagName="ProfileFields" TagPrefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <div><asp:Label ID="ucHeaderText" runat="server" meta:ResourceKey="ucHeaderText"></asp:Label></div>
                <br />
                <div><asp:Label Font-Bold="true" ID="realmLabel" runat="server" meta:ResourceKey="realmLabel"></asp:Label></div>
                <br />
	            <uc1:ProfileFields ID="profileFields" runat="server" Visible="false" />
	            <br /> 
	            <asp:Button ID="yes_button" OnClick="Yes_Click" runat="Server"  meta:ResourceKey="yes_button"/>
	            <asp:Button ID="no_button" OnClick="No_Click" runat="Server" meta:ResourceKey="no_button" />                
                <br /><br /> 
                <br /><br />                  
            </div>
          </div>
    </asp:panel>
    <asp:Panel ID="ucMessageContainer" runat="server" Visible="false">
        <asp:Label ID="ucMessages" runat="server" />
    </asp:Panel>
</div>
</asp:Content>
