<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="ResetPassword" CodeBehind="resetPassword.aspx.cs" Inherits="DotOrg.resetPassword" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <asp:PasswordRecovery ID="PasswordRecovery" runat="server" meta:ResourceKey="PasswordRecovery">
                    <MailDefinition BodyFileName="~/EmailTemplates/ResetPassword.txt" Subject="Password Reset" />
                    <UserNameTemplate>
                        <div><asp:label ID="ucEnterUsernameLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucEnterUsernameLabel" /></div>
                        <div><asp:TextBox ID="UserName" runat="server" Columns="30" class="Label" meta:ResourceKey="UserName"></asp:TextBox></div>
                        <div>
                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ValidationGroup="PasswordRecovery" meta:ResourceKey="UserNameRequired"></asp:RequiredFieldValidator>
                        </div>
                        <div style="padding-bottom:5px;"><asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal></div>
                        <asp:Button ID="SubmitButton" runat="server" CommandName="Submit" ValidationGroup="PasswordRecovery" meta:ResourceKey="SubmitButton" />
                    </UserNameTemplate>                
                    <QuestionTemplate>
                        <div><asp:label ID="ucConfirmedUsernameLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucConfirmedUsernameLabel" /> : <asp:Literal ID="UserName" runat="server"></asp:Literal></div>
                        <br />
                        <div>
                            <asp:label ID="ucQuestionLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucQuestionLabel" />
                            <asp:ListBox ID="Question" runat="server" class="Label" meta:ResourceKey="Question" Rows="1"></asp:ListBox>
                        </div>
                        <br />
                        <div>
                            <asp:label ID="AnswerLabel" runat="server" class="LabelHeader" AssociatedControlID="Answer" meta:ResourceKey="ucAnswerLabel" />
                            <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" 
                                ControlToValidate="Answer" ValidationGroup="PasswordRecovery" />
                        </div> 
                         <br />
                        <div style="padding-bottom:5px;"><asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal></div>
                       
                        <asp:Button ID="SubmitButton" runat="server" CommandName="Submit" ValidationGroup="PasswordRecovery" meta:ResourceKey="SubmitButton" />
                    </QuestionTemplate>
                    <SuccessTemplate>
                        <asp:label ID="ucSuccessLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucSuccessLabel" />
                    </SuccessTemplate>
                </asp:PasswordRecovery>
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