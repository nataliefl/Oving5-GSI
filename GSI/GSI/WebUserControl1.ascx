<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="GSI.WebUserControl1" ClassName="cLogin" %>
<asp:Label ID="lbl1" runat="server" Text="Label">Welcome!</asp:Label>
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
<asp:Button ID="btnLogin" runat="server" Text="Login" ValidationGroup="login" 
    onclick="btnLogin_Click" style="height: 26px" />



