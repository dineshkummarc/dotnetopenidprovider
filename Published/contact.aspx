<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="Contact" CodeBehind="contact.aspx.cs" Inherits="DotOrg.contact" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>    
    <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
    <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
    <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
        <div style="margin: 25px 25px 25px 25px;"><br />
            <asp:panel ID="ucMainContainer" runat="server">
                <div><asp:label ID="ucEmailLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucEmailLabel" /></div>
                <div><asp:TextBox ID="UsersEmail" runat="server" Columns="30" class="Label" meta:ResourceKey="UsersEmail"></asp:TextBox></div>
                <br />
                <div><asp:label ID="ucSubjectLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucSubjectLabel" /></div>
                <div><asp:TextBox ID="Subject" runat="server" Columns="30" class="Label" meta:ResourceKey="Subject"></asp:TextBox></div>                    
                <br />
                <div><asp:label ID="ucBodyLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucBodyLabel" /></div>
                <div><asp:TextBox ID="Body" runat="server" TextMode="MultiLine"  Columns="30" Rows="5" class="Label" meta:ResourceKey="Body"></asp:TextBox></div> 
                <br />
                <asp:Button runat="server" ID="SendEmail" OnClick="SendEmail_Click" meta:ResourceKey="SendEmail" />
            </asp:Panel>
            <asp:Panel ID="ucMessageContainer" runat="server" Visible="false">
                <asp:Label ID="ucMessages" runat="server" />
            </asp:Panel>
            <br /><br />        
        </div>
      </div>
</div>
</asp:Content>
