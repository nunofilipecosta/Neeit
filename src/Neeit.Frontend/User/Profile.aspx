<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Neeit.Frontend.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <h1>O meu Perfil</h1>
    <table>
        <tr>
            <td>
                UserName :
            </td>
            <td>
                <asp:TextBox ID="tb_Username" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Nome :
            </td>
            <td>
                <asp:TextBox ID="tb_FullName" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                 Curso :
            </td>
            <td>
                <asp:TextBox ID="tb_curso" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Data de Nascimento :
            </td>
            <td>
                <asp:TextBox ID="tb_BirthDate" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                 Localidade :
            </td>
            <td>
                <asp:TextBox ID="tb_adress" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
     <a href="../User/EditUserInfo.aspx">Editar Dados</a>
</asp:Content>
