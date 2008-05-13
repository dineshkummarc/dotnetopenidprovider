<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" meta:resourcekey="ChangeSecretQuestion" CodeBehind="changeSecretQuestion.aspx.cs" Inherits="DotOrg.changeSecretQuestion" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:panel ID="ucMainContainer" runat="server">
        <div><asp:label ID="ucSubTitle" runat="server" class="LabelTitle" meta:ResourceKey="ucSubTitle"></asp:label></div>
        <div><asp:label ID="ucSubTitleTagLine" runat="server" class="LabelSubTitle" meta:ResourceKey="ucSubTitleTagLine"></asp:label></div>
        <div class="MainOpenIDBoxRegister" ID="ucInitialContainer" runat="server">
            <div style="margin: 25px 25px 25px 25px;"><br />
                <asp:Panel ID="ucChangeQuestionPanel" runat="server">
                    <div><asp:label ID="ucPasswordLabel" runat="server" class="LabelHeader" meta:ResourceKey="ucPasswordLabel" Text="Enter your password"></asp:label></div>
                    <div><asp:TextBox ID="Password" runat="server" Columns="25" TextMode="Password" class="Label" meta:ResourceKey="ucPassword"></asp:TextBox></div>
                    <div><asp:RequiredFieldValidator id="ucPasswordRequiredFieldValidator" ControlToValidate="Password" Runat="server" Display="Dynamic" meta:ResourceKey="ucPasswordRequiredFieldValidator"/></div>
                    <br />
                    <div>
                    	<asp:Label ID="QuestionLabel" class="LabelHeader" runat="server" meta:ResourceKey="QuestionLabel" AssociatedControlID="Question"></asp:Label>
                    	<br />
                    	<asp:ListBox ID="Question" runat="server" class="Label" meta:ResourceKey="Question" Rows="1"></asp:ListBox>
                    	<br />
                    	<br />
		            </div>    
                    <div>
			            <asp:Label ID="AnswerLabel" class="LabelHeader" runat="server" meta:ResourceKey="AnswerLabel" AssociatedControlID="Answer"></asp:Label></div>
			            <div><asp:TextBox ID="Answer" runat="server" class="Label" meta:ResourceKey="Answer"></asp:TextBox></div>
                    	<div>
                        	<asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" meta:ResourceKey="AnswerRequired"/>
                    	</div> 
		            </div>
                    <asp:Button ID="UpdateDetails" OnClick="UpdateDetails_OnClick" runat="server" meta:ResourceKey="UpdateDetails" />
                   
                </asp:Panel>
                <asp:Panel ID="ucMessageContainer" runat="server" Visible="false">
                    <asp:Label ID="ucMessages" runat="server" />
                </asp:Panel>                
                <br /><br />        
                <br /><br />                  
            </div>
          </div>
    </asp:panel>
</div>
</asp:Content>
