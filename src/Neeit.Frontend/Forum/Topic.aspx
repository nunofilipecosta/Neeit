<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Topic.aspx.cs" Inherits="Neeit.Frontend.Forum.Topic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gv_TopicPost" runat="server"></asp:GridView>
    <asp:GridView ID="gv_Post" runat="server"></asp:GridView>


</asp:Content>
