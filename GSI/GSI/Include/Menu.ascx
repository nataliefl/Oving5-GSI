<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="GSI.NonSecure.Menu" %>

<table width="100%">
<tr>
    
<td>
   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="/Secure/default.aspx">Home</asp:HyperLink>
   &nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="/NonSecure/logon.aspx">Login</asp:HyperLink>
    &nbsp;
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/NonSecure/register.aspx">Register</asp:HyperLink> 
    &nbsp;
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="/Secure/Teams.aspx">View Teams</asp:HyperLink> 

</td>
<td align="right">
    <asp:LoginView runat="server" ID="LoginView1">
            <AnonymousTemplate>
                Welcome Guest
            </AnonymousTemplate>
            <LoggedInTemplate>
                Welcome <asp:LoginName runat="server" ID="LoginName1"/> ,
                <asp:LoginStatus runat="server" ID="LoginStatus1"/>
            </LoggedInTemplate>
            
        </asp:LoginView>

</td>
</tr>
</table>


