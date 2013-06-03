using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Neeit.Frontend.Forum
{
    public partial class Topic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int topicId = int.Parse(Request.QueryString["id"].ToString());



            //primeiro passo crio a connection string
            String strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
            //segundo passo crio a minha connection em modo connected
            SqlConnection MyConn = new SqlConnection(strConn);
            //terceiro passo criar a instrução a executar
            string sqlStringSelectTabelaDonos = "Select tbl_Topics.TopicId as 'Numero', tbl_Topics.TopicTitle as 'Titulo', aspnet_Users.UserName as 'User', tbl_TopicsUsers.date as 'Data' From tbl_Topics,tbl_TopicsUsers,aspnet_Users where tbl_Topics.TopicId=tbl_TopicsUsers.TopicId and  tbl_TopicsUsers.UserId=aspnet_Users.UserId and Numero = '"+topicId+"';";
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
                gv_TopicPost.DataSource = myReader;
                //o data bind força os objectos a reutilizar os dados entregues
                gv_TopicPost.DataBind();
                MyConn.Close();
            }
            catch (Exception x)
            {
                //sem excepção
            }

            sqlStringSelectTabelaDonos = "SELECT tbl_Posts.PostId,tbl_Posts.PostContent, aspnet_Users.UserName,tbl_PostsTopics.date FROM tbl_Posts,tbl_PostsTopics,aspnet_Users where tbl_Posts.PostId = tbl_PostsTopics.PostId and tbl_PostsTopics.TopicId = tbl_Topics.TopicId and tbl_PostsTopics.UserId= aspnet_Users.UserId and tbl_PostsTopics.TopicId = '"+topicId+"';"; 
            //crio o objecto que recebe os dados da base de dados
           Cmd_MostraRegistos = new SqlCommand(sqlStringSelectTabelaDonos, MyConn);
            //cria o objecto que recebe os dados da base de dados


            //abre a ligação à BD
            try
            {
                MyConn.Open();
                myReader = Cmd_MostraRegistos.ExecuteReader();
                //carrega os dados na grid view
                gv_TopicPost.DataSource = myReader;
                //o data bind força os objectos a reutilizar os dados entregues
                gv_TopicPost.DataBind();
                MyConn.Close();
            }
            catch (Exception x)
            {
                //sem excepção
            }





            
        }
    }
}