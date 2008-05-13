<%@ Page Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" meta:resourcekey="User" CodeBehind="user.aspx.cs" Inherits="DotOrg.user"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:panel ID="ucMainContainer" runat="server">
            <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
            <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
            <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
                <div style="margin: 25px 25px 25px 25px;"><br />
		            <asp:label ID="ucUsernamePreamble" runat="server" class="Label" meta:ResourceKey="ucUsernamePreamble"></asp:label> <asp:Label class="Label" runat="server" ID="usernameLabel" EnableViewState="false" />          
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
