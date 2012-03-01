<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="GSI.WebForm3" %>
<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblRegister" runat="server" 
        Text="Welcome, enter registration details!"></asp:Label>
    <uc1:WebUserControl1 ID="WebUserControl11" runat="server" />
    <br />
    <asp:Label ID="lblSucceded" runat="server" Text=""></asp:Label>
    <br />
</asp:Content>
