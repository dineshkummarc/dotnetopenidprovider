<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="DotOrg.changePassword" meta:resourcekey="ChangePassword"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;">
                <asp:ChangePassword ID="ChangePassword" runat="server">
                    <ChangePasswordTemplate>
                        <div><asp:label ID="ucChangePassword" runat="server" class="LabelHeader" meta:ResourceKey="ucQuestionLabel" /></div>
                        <br />
                        <div>
                            <asp:label ID="ucCurrentPasswordLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucCurrentPasswordLabel" />
                            <div><asp:TextBox ID="CurrentPassword"  TextMode="Password" runat="server" Columns="30" class="Label" meta:ResourceKey="CurrentPassword"></asp:TextBox></div>
                            <div>
                                <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server"  meta:ResourceKey="CurrentPasswordRequired"
                                    ControlToValidate="CurrentPassword" ValidationGroup="ChangePassword" />
                            </div>
                        </div>
                        <div>
                            <asp:label ID="NewPasswordLabel" runat="server" class="LabelHeader" meta:ResourceKey="NewPasswordLabel" AssociatedControlID="NewPassword" />
                            <div><asp:TextBox ID="NewPassword"  TextMode="Password" runat="server" Columns="30" class="Label" meta:ResourceKey="NewPassword"></asp:TextBox></div>
                            <div>
                                <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" meta:ResourceKey="NewPasswordRequired" 
                                    ControlToValidate="NewPassword" ValidationGroup="ChangePassword" />
                            </div>
                        </div>
                        <div>
                            <asp:label ID="ConfirmNewPasswordLabel" runat="server" class="LabelHeader" meta:ResourceKey="ConfirmNewPasswordLabel" AssociatedControlID="ConfirmNewPasswordLabel" />
                            <div><asp:TextBox ID="ConfirmNewPassword"  TextMode="Password" runat="server" Columns="30" class="Label" meta:ResourceKey="ConfirmNewPassword"></asp:TextBox></div>
                            <div>
                                    <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" meta:ResourceKey="ConfirmNewPasswordRequired" 
                                        ControlToValidate="ConfirmNewPassword" ValidationGroup="ChangePassword" />
                            </div>
                        </div> 
                        <div>
                            <asp:CompareValidator ID="NewPasswordCompare" runat="server" meta:ResourceKey="NewPasswordCompare"
                                ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" 
                                Display="Dynamic" 
                                ValidationGroup="ChangePassword"></asp:CompareValidator>
                        </div>                   
                        <div>
                            <asp:Button ID="ChangePasswordPushButton" runat="server" CommandName="ChangePassword"  ValidationGroup="ChangePassword" meta:ResourceKey="ChangePasswordPushButton" />
                        </div>
                    </ChangePasswordTemplate>
                    <SuccessTemplate>
                        <asp:label ID="ucSuccessLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucSuccessLabel" />
                    </SuccessTemplate>
                </asp:ChangePassword>
                <br />
                <div>
                    <asp:label ID="ucChangeQuestion" runat="server" class="LabelHeader" meta:ResourceKey="ucChangeQuestion" />
                </div>

                &nbsp;<br /><br />        
                <br /><br />                  
            </div>
          </div>
    </asp:panel>
    <asp:Panel ID="ucMessageContainer" runat="server" Visible="false">
        <asp:Label ID="ucMessages" runat="server" />
    </asp:Panel>
</div>
</asp:Content>
