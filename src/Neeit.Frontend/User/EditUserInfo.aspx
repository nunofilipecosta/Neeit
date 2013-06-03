<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUserInfo.aspx.cs" Inherits="Neeit.Frontend.User.EditUserInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 717px;
        }

        .auto-style2 {
            width: 206px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Edite os seus dados pessoais</h1>
    <table>
        <tr>
            <td class="auto-style2">UserName :
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="tb_Username" runat="server" Enabled="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Nome :
            </td>
            <td class="auto-style1">

                <asp:TextBox ID="tb_FullName" runat="server" Enabled="true"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Insira um Nome correto - Não Coloque Assentos" ControlToValidate="tb_FullName" ValidationExpression="[A-Za-z]+(\s[A-Za-z]+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Curso :
            </td>
            <td class="auto-style1">

                <asp:TextBox ID="tb_Curso" runat="server" Enabled="true"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_Curso" ErrorMessage="Insira um curso válido  - Não Coloque Assentos" ValidationExpression="[A-Za-z]+(\s[A-Za-z]+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Data de Nascimento :
            </td>
            <td class="auto-style1">

                <asp:TextBox ID="tb_BirthDate" runat="server" Enabled="true"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tb_BirthDate" ErrorMessage="AAAA / MM / DD"
                    ValidationExpression="^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Localidade :              
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="tb_Adress" runat="server" Enabled="true"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="tb_Adress" ErrorMessage="Insira uma localidade válida " ValidationExpression="[A-Za-z]+(\s[A-Za-z]+)*"></asp:RegularExpressionValidator>

               
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style1">
                <asp:Button ID="bt_Dados" runat="server" Text="Enviar Dados" OnClick="bt_Dados_Click" />
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" Insira um Nome " ControlToValidate="tb_FullName"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" Insira uma Data " ControlToValidate="tb_BirthDate"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Insira um Curso " ControlToValidate="tb_Curso"></asp:RequiredFieldValidator><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Insira uma Localidade " ControlToValidate="tb_Adress"></asp:RequiredFieldValidator><br />
            </td>
        </tr>
    </table>
</asp:Content>
