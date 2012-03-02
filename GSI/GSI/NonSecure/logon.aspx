<%@ Page Title="Logon" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="logon.aspx.cs" Inherits="GSI.WebForm1" %>
<%@ Register src="~/Include/CredentialsForm.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:WebUserControl1 runat="server" ID="WebUserControl11" ></uc1:WebUserControl1>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
