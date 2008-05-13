<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="ChangeEmail" CodeBehind="changeEmail.aspx.cs" Inherits="DotOrg.changeEmail" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <asp:panel ID="ucMainContainer" runat="server">
                    <div><asp:label ID="ucPasswordLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucPasswordLabel"></asp:label></div>
                    <div><asp:TextBox ID="Password" runat="server" Columns="25" TextMode="Password" class="Label" meta:ResourceKey="ucPassword"></asp:TextBox></div>
                    <div>
                            <asp:RequiredFieldValidator
                                    id="ucPasswordRequiredFieldValidator"
                                    ControlToValidate="Password"
                                    Runat="server"
                                    Display="Dynamic"
                                    meta:ResourceKey="ucPasswordRequiredFieldValidator"/>
                    </div>
                    <br />                
                    <div><asp:label ID="ucEmailLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucEmailLabel"></asp:label></div>
                    <div><asp:TextBox ID="Email" runat="server" Columns="25" class="Label" meta:ResourceKey="ucEmail"></asp:TextBox></div>
                    <div>
                            <asp:RequiredFieldValidator
                                    id="emailRequiredFieldValidator"
                                    ControlToValidate="Email"
                                    Runat="server"
                                    Display="Dynamic"
                                    meta:ResourceKey="emailRequiredFieldValidator"
                                    />
                            <asp:RegularExpressionValidator
                                id="emailRegularExpressionValidator"
                                ControlToValidate="Email"
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                Runat="server" 
                                Display="Dynamic"
                                meta:ResourceKey="emailRegularExpressionValidator"
                                />        
                    </div>
                    <br />
                    <asp:Button ID="UpdateDetails" OnClick="UpdateDetails_OnClick" runat="server" meta:ResourceKey="UpdateDetails" />
                </asp:panel>
                <asp:Panel ID="ucMessageContainer" runat="server" Visible="false">
                    <asp:Label ID="ucMessages" runat="server" />
                </asp:Panel>
                <br /><br />        
                <br /><br />                  
            </div>
          </div>
    </div>
</asp:Content>