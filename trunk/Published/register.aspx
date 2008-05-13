<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="Register" CodeBehind="register.aspx.cs" Inherits="DotOrg.register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <asp:CreateUserWizard ID="UserWizard" runat="server" DisableCreatedUser="True" 
                    OnSendingMail="SendMail" CreateUserButtonText="test" meta:ResourceKey="UserWizard">
                    <MailDefinition BodyFileName="~/EmailTemplates/CreateUserWizard.txt" />
                    <FinishNavigationTemplate>
                        <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" 
                            CommandName="MovePrevious" Text="Previous" />
                        <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" 
                            Text="Finish" />
                    </FinishNavigationTemplate>
                    <WizardSteps>
                        <asp:CreateUserWizardStep runat="server">
                            <ContentTemplate>
                                <div><asp:label ID="ucUsernameLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucUsernameLabel"></asp:label></div>
                                <div><asp:TextBox ID="UserName" runat="server" Columns="25" class="Label" meta:ResourceKey="ucUsername"></asp:TextBox></div>
                                <div>
                                    <asp:RequiredFieldValidator 
                                        id="usernameRequiredValidator" 
                                        ControlToValidate="UserName" 
                                        Runat="server" 
                                        Display="Dynamic"
                                        ValidationGroup="UserWizard" 
                                        meta:ResourceKey="usernameRequiredValidator" />
                                </div>
                                <br />
                                <div><asp:label ID="ucEmailLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucEmailLabel"></asp:label></div>
                                <div><asp:TextBox ID="Email" runat="server" Columns="25" class="Label" meta:ResourceKey="ucEmail"></asp:TextBox></div>
                                <div>
                                        <asp:RequiredFieldValidator
                                                id="emailRequiredFieldValidator"
                                                ControlToValidate="Email"
                                                Runat="server"
                                                ValidationGroup="UserWizard" 
                                                Display="Dynamic"
                                                meta:ResourceKey="emailRequiredFieldValidator"
                                                />
                                        <asp:RegularExpressionValidator
                                            id="emailRegularExpressionValidator"
                                            ControlToValidate="Email"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                            Runat="server" 
                                            ValidationGroup="UserWizard" 
                                            Display="Dynamic"
                                            meta:ResourceKey="usernameRequiredValidator"
                                            />        
                                </div>
                                <br />
                                <div><asp:label ID="ucPasswordLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucPasswordLabel"></asp:label></div>
                                <div><asp:TextBox ID="Password" runat="server" Columns="25" TextMode="Password" class="Label" meta:ResourceKey="ucPassword"></asp:TextBox></div>
                                <div>
                                        <asp:RequiredFieldValidator
                                                id="ucPasswordRequiredFieldValidator"
                                                ControlToValidate="Password"
                                                Runat="server"
                                                Display="Dynamic"
                                                ValidationGroup="UserWizard" 
                                                meta:ResourceKey="ucPasswordRequiredFieldValidator"/>
                                </div>
                                <br />
                                <div><asp:label ID="ucPasswordLabel2" runat="server" class="LabelHeader" meta:ResourceKey="ucPasswordLabel2"></asp:label></div>
                                <div><asp:TextBox ID="ConfirmPassword" runat="server" Columns="25" TextMode="Password" class="Label" meta:ResourceKey="ucPassword2"></asp:TextBox></div>
                                <div>
                                        <asp:RequiredFieldValidator
                                                id="RequiredFieldValidator2"
                                                ControlToValidate="Password"
                                                Runat="server"
                                                Display="Dynamic"
                                                meta:ResourceKey="RequiredFieldValidator2"
                                                ValidationGroup="UserWizard" 
                                                />
                                        <asp:CompareValidator 
                                                ID="ucPasswordCompareValidator" 
                                                runat="server"
                                                ControlToValidate="Password"
                                                ControlToCompare="ConfirmPassword"
                                                Display="Dynamic"
                                                meta:ResourceKey="ucPasswordCompareValidator"
                                                ValidationGroup="UserWizard" 
                                                />
                                </div>
                                <br />
                                <div>
                                <asp:Label ID="QuestionLabel" class="LabelHeader" runat="server" meta:ResourceKey="QuestionLabel" AssociatedControlID="Question"></asp:Label></div>
                                <div><asp:ListBox ID="Question" runat="server" class="Label" meta:ResourceKey="Question" Rows="1"></asp:ListBox></div>
                                <br />
                                <div>
                                <asp:Label ID="AnswerLabel" class="LabelHeader" runat="server" meta:ResourceKey="AnswerLabel" AssociatedControlID="Answer"></asp:Label></div>
                                <div><asp:TextBox ID="Answer" runat="server" class="Label" meta:ResourceKey="Answer" Columns="40"></asp:TextBox></div>
                                <div>
                                    <asp:RequiredFieldValidator 
                                            ID="AnswerRequired" 
                                            runat="server" 
                                            ControlToValidate="Answer" 
                                            ValidationGroup="UserWizard" 
                                            Display="Dynamic"
                                            meta:ResourceKey="AnswerRequired"/>
                                </div> 
                                <div class="LabelHeader"><asp:HyperLink ID="ucTerms" runat="server" NavigateUrl="~/terms.aspx" Target="_blank" meta:ResourceKey="ucTerms"></asp:HyperLink></div>
                            </ContentTemplate>
                        </asp:CreateUserWizardStep>
                        <asp:CompleteWizardStep runat="server" >
                            <ContentTemplate>
                                <div><asp:Label ID="CompleteLabel" class="LabelHeader" runat="server" meta:ResourceKey="CompleteLabel"></asp:Label></div>
                            </ContentTemplate>
                        </asp:CompleteWizardStep>
                    </WizardSteps>
                </asp:CreateUserWizard>
                <br /><br />        
                <br /><br />                  
            </div>
          </div>
    </asp:panel>
</div>
</asp:Content>