<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Teams.aspx.cs" Inherits="GSI.Secure.Teams" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ddlSelectSport" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="Sport" DataValueField="Sport">
    </asp:DropDownList>
    <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Navn" HeaderText="Navn" SortExpression="Navn" />
        </Columns>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:GSIDatabaseConnectionString %>" 
        SelectCommand="SELECT Navn FROM Sport GROUP BY Navn"></asp:SqlDataSource>
    </asp:Content>
