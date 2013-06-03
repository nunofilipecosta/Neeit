using Neeit.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Neeit.Frontend.User
{
    public partial class EditUserInfo : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                tb_Username.Text = User.Identity.Name;
                
                var database = new DatabaseGateway();
                NeeitUser currentUser = database.GetUser(User.Identity.Name);
               
                tb_Adress.Text = currentUser.Address;
                tb_BirthDate.Text = currentUser.BirthDate;
                tb_Curso.Text = currentUser.Curso;
                tb_FullName.Text = currentUser.FullName;

            }
        }

        protected void bt_Dados_Click(object sender, EventArgs e)
        {

            
            try
            {
                var database = new DatabaseGateway();
                
               database.InsertUserData(tb_FullName.Text, tb_BirthDate.Text, tb_Adress.Text, tb_Curso.Text, User.Identity.Name);
                Response.Redirect("~/User/Profile.aspx");
            }
            catch (Exception ex)
            {
                string myScript = @"alert('Houve um erro no acesso aos dados...\nErro: " + ex.Data.Values.ToString() + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Erro", myScript, true);
            }
        }
    }
}