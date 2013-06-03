<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Topics.aspx.cs" Inherits="Neeit.Frontend.Forum.Topics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="../Forum/NewTopic.aspx">Novo Topico</a><br />
    &nbsp;<asp:GridView ID="gv_Topics" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="543px" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="White" />
       

        <Columns>
            <asp:HyperLinkField DataTextField="Numero" Text="Ver" 
                DataNavigateUrlFields="Numero" DataNavigateUrlFormatString="~/Forum/Topic.aspx?id={0}"/>
                        
            <asp:BoundField DataField="Titulo" />
            <asp:BoundField DataField="User"/>
            <asp:BoundField DataField="Data"/>
            <asp:BoundField DataField=""/>

        </Columns>
       

        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

   



</asp:Content>
