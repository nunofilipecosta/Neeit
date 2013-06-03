<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Neeit.Frontend.Forum.Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="left:80px; position:absolute">Users</h1>
    <div style="overflow-y:auto; top:80px; left:20px; position:absolute;">
        <asp:GridView ID="gv_Users" runat="server"></asp:GridView>
    </div>

</asp:Content>
