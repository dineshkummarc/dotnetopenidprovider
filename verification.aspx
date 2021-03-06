﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="Verify" CodeBehind="verification.aspx.cs" Inherits="DotOrg.verification" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <asp:Label ID="StatusMessage" runat="server" Text="Label"></asp:Label>
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