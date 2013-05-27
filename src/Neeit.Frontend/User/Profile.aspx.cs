using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; //introduzi
using System.Data;  //introduzi
using System.Data.SqlClient; //introduzi
using System.Data.Sql; //introduzi

namespace Neeit.Frontend
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tb_Username.Text = User.Identity.Name;
            //primeiro passo crio a connection string
            String strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            //segundo passo crio a minha connection em modo connected
            SqlConnection MyConn = new SqlConnection(strConn);
            //terceiro passo criar a instrução a executar
            string sqlStringSelectTabelaDonos = "Select * from aspnet_Users Where UserName ='"+User.Identity.Name+"';";
            //crio o objecto que recebe os dados da base de dados
            SqlCommand Cmd_MostraRegistos = new SqlCommand(sqlStringSelectTabelaDonos, MyConn);
            //cria o objecto que recebe os dados da base de dados
            SqlDataReader myReader;

            //abre a ligação à BD

            try
            {
                MyConn.Open();
                myReader = Cmd_MostraRegistos.ExecuteReader();
                myReader.Read();
                tb_BirthDate.Text = myReader["BirthDate"].ToString();        //TBname is my TextBox and name is the data I want to fill in it
                tb_adress.Text = myReader["Adress"].ToString();
                tb_curso.Text = myReader["Curso"].ToString();
                tb_FullName.Text = myReader["FullName"].ToString();
                
                myReader.Close();
            }
            finally
            {
                MyConn.Close();
            }
       





        }
    }
}