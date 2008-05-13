<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfileFields.ascx.cs" Inherits="DotOrg.ProfileFields"%>
<div><asp:label ID="ucConsumerRequest" runat="server" class="Label" meta:ResourceKey="ucConsumerRequest"></asp:label> (<asp:HyperLink ID="privacyLink" CssClass="Label" runat="server" Target="_blank" meta:ResourceKey="privacyLink" />) :</div>
<br />
<asp:Panel ID="nicknameRow" runat="server">
    <div><asp:Label ID="ucNickname" runat="server" meta:ResourceKey="ucNickname"></asp:Label> <asp:Label ID="nicknameRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div><asp:TextBox ID="nicknameTextBox" runat="server"></asp:TextBox></div>
</asp:Panel>
<asp:Panel ID="emailRow" runat="server">
    <div><asp:Label ID="ucEmail" runat="server" meta:ResourceKey="ucEmail"></asp:Label> <asp:Label ID="emailRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div><asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></div>
</asp:Panel>
<asp:Panel ID="fullnameRow" runat="server">
    <div><asp:Label ID="ucFullName" runat="server" meta:ResourceKey="ucFullname"></asp:Label> <asp:Label ID="fullnameRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div><asp:TextBox ID="fullnameTextBox" runat="server"></asp:TextBox></div>
</asp:Panel>
<asp:Panel ID="dateOfBirthRow" runat="server">
    <div><asp:Label ID="ucDateOfBirth" runat="server" meta:ResourceKey="ucDateOfBirth"></asp:Label> <asp:Label ID="dobRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div>
		    <asp:DropDownList ID="dobDayDropdownlist" runat="server" />
		    &nbsp;<asp:DropDownList ID="dobMonthDropdownlist" runat="server" />
		    &nbsp;
		    <asp:DropDownList ID="dobYearDropdownlist" runat="server" />  
    </div>
</asp:Panel>
<asp:Panel ID="genderRow" runat="server">
    <div><asp:Label ID="ucGender" runat="server" meta:ResourceKey="ucGender"></asp:Label> <asp:Label ID="genderRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div>
        <asp:DropDownList ID="genderDropdownList" runat="server" />
    </div>
</asp:Panel>

<asp:Panel ID="postcodeRow" runat="server">
    <div><asp:Label ID="ucPostcode" runat="server" meta:ResourceKey="ucPostcode"></asp:Label> <asp:Label ID="postcodeRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div>
        <asp:TextBox ID="postcodeTextBox" runat="server"></asp:TextBox>   
    </div>
</asp:Panel>

<asp:Panel ID="countryRow" runat="server">
    <div><asp:Label ID="ucCountry" runat="server" meta:ResourceKey="ucCountry"></asp:Label> <asp:Label ID="countryRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div>
        <asp:DropDownList ID="countryDropdownList" runat="server" />
    </div>
</asp:Panel>

<asp:Panel ID="languageRow" runat="server">
    <div><asp:Label ID="ucLanguage" runat="server" meta:ResourceKey="ucLanguage"></asp:Label> <asp:Label ID="languageRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div>
		<asp:DropDownList ID="languageDropdownList" runat="server" />
    </div>
</asp:Panel>

<asp:Panel ID="timezoneRow" runat="server">
    <div><asp:Label ID="ucTimezone" runat="server" meta:ResourceKey="ucTimezone"></asp:Label> <asp:Label ID="timezoneRequiredLabel" runat="server" Text="*" Visible="False"></asp:Label></div>
    <div>
		<asp:DropDownList runat="server" ID="timezoneDropdownList" />
    </div>
</asp:Panel>