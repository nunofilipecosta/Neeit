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

namespace Neeit.Frontend.Forum
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //primeiro passo crio a connection string
            String strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            //segundo passo crio a minha connection em modo connected
            SqlConnection MyConn = new SqlConnection(strConn);
            //terceiro passo criar a instrução a executar
            string sqlStringSelectTabelaDonos = "Select UserName,FullName,Curso from aspnet_Users where ApplicationId='5424616e-9e27-4884-841c-85cf304dc318' ;";
            //crio o objecto que recebe os dados da base de dados
            SqlCommand Cmd_MostraRegistos = new SqlCommand(sqlStringSelectTabelaDonos, MyConn);
            //cria o objecto que recebe os dados da base de dados
            SqlDataReader myReader;

            //abre a ligação à BD
            try
            {
                MyConn.Open();
                myReader = Cmd_MostraRegistos.ExecuteReader();
                //carrega os dados na grid view
                gv_Users.DataSource = myReader;
                //o data bind força os objectos a reutilizar os dados entregues
                gv_Users.DataBind();
                MyConn.Close();
            }
            catch (Exception x)
            {
                //sem excepção
            }
        }
    }
}
