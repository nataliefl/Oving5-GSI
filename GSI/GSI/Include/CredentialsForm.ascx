<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CredentialsForm.ascx.cs" Inherits="GSI.WebUserControl1" ClassName="cLogin" %>
<br />
<asp:Label ID="lblUsername" runat="server" Text="Label">Username : </asp:Label>
<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
ControlToValidate="txtUsername" ErrorMessage="*" ValidationGroup="login" ></asp:RequiredFieldValidator>
<br />
<asp:Label ID="lblPassword" runat="server" Text="Label">Password : </asp:Label>
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
    ErrorMessage="*" ControlToValidate="txtPassword"  
    ValidationGroup="login"></asp:RequiredFieldValidator>

<br />
<asp:Button ID="btnLogin" runat="server" Text="Go!" ValidationGroup="login" 
    onclick="btnLogin_Click" style="height: 26px" />



