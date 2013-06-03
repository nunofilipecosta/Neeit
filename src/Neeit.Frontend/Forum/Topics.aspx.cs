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
    public partial class Topics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //primeiro passo crio a connection string
            String strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            //segundo passo crio a minha connection em modo connected
            SqlConnection MyConn = new SqlConnection(strConn);
            //terceiro passo criar a instrução a executar
            string sqlStringSelectTabelaDonos = "Select tbl_Topics.TopicId as 'Numero', tbl_Topics.TopicTitle as 'Titulo', aspnet_Users.UserName as 'User', tbl_TopicsUsers.date as 'Data' From tbl_Topics,tbl_TopicsUsers,aspnet_Users where tbl_Topics.TopicId=tbl_TopicsUsers.TopicId and  tbl_TopicsUsers.UserId=aspnet_Users.UserId  ORDER BY Numero DESC;";
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
                gv_Topics.DataSource = myReader;
                //o data bind força os objectos a reutilizar os dados entregues
                gv_Topics.DataBind();
                MyConn.Close();
            }
            catch (Exception x)
            {
                //sem excepção
            }

        }
    }
}