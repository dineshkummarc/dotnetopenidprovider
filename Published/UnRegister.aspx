<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="UnRegister" CodeBehind="UnRegister.aspx.cs" Inherits="DotOrg.UnRegister" Title="UnRegister" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <asp:Label runat="server" ID="ucReasonLabel" class="LabelSubTitle" meta:ResourceKey="ucReasonLabel" />
                <br />
                <asp:TextBox runat="server" ID="Body" TextMode="MultiLine" Columns="55" Rows="5"></asp:TextBox>
                <br /><br />
                <asp:Button ID="ucConfirmRemoval" runat="server" meta:ResourceKey="ucConfirmRemoval" OnClick="ConfirmRemoval" />
                <br /><br />
                <asp:Label runat="server" ID="ucWarning" class="LabelSubTitle" meta:ResourceKey="ucWarning" />
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
