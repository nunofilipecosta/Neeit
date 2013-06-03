<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewTopic.aspx.cs" Inherits="Neeit.Frontend.Forum.NewTopic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Adicionar Novo Topico</h1>
    <table>
        <tr>
            <td>
                Titulo:
            </td>
            <td>
                <asp:TextBox ID="tb_Title" runat="server" Width="261px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                Conteúdo:
            </td>
            <td>
                <asp:TextBox ID="tb_Content" runat="server" Height="170px" Width="429px"></asp:TextBox>

            </td>
        </tr>
         <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="bt_commitTopic" runat="server" Text="Submeter Tópico" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>




</asp:Content>
