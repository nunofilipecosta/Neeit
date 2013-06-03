using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; //introduzi
using System.Data;  //introduzi
using System.Data.SqlClient; //introduzi
using System.Data.Sql;
using Neeit.Core;
using System.Web.Security; //introduzi

namespace Neeit.Frontend
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var database = new DatabaseGateway();
            NeeitUser currentUser = database.GetUser(User.Identity.Name);

            tb_Username.Text = User.Identity.Name;
            tb_adress.Text = currentUser.Address;
            tb_BirthDate.Text = currentUser.BirthDate;
            tb_curso.Text = currentUser.Curso;
            tb_FullName.Text = currentUser.FullName;
        }
    }
}