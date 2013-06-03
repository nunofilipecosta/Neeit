using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Neeit.Core
{
    public class DatabaseGateway
    {
        String strConn; 

        public DatabaseGateway()
        {
            this.strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;
        }

        public void InsertUserData(string fullName, string birthDate, string address, string curso, string currentUser)
        {
            //Atualiza os dados, na Base de Dados

            //obtém a "Connection String", lendo-a do web.config
            string strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;

            //cria o objeto "Connection"
            SqlConnection MyConn = new SqlConnection(strConn);

            //define o comando SQL a executar
            string strSQL = "UPDATE aspnet_Users SET FullName=@fullName, BirthDate=@birthDate, Adress=@adress, Curso=@curso WHERE aspnet_Users.UserName='" + currentUser + "';";

            //cria o objeto "Command"
            SqlCommand MyCommand = new SqlCommand(strSQL, MyConn);

            //configura o Command
            MyCommand.Parameters.AddWithValue("@fullName", fullName);
            MyCommand.Parameters.AddWithValue("@birthDate",birthDate);
            MyCommand.Parameters.AddWithValue("@adress", address);
            MyCommand.Parameters.AddWithValue("@curso",curso);

            try
            {
                //abre a ligação à BD
                MyConn.Open();

                //'carrega' o DataReader
                MyCommand.ExecuteNonQuery();
            }
            finally
            {
                MyConn.Close();
            }


        }

        public NeeitUser GetUser(string username)
        {
            var currentUser = new NeeitUser();
            //segundo passo crio a minha connection em modo connected
            SqlConnection MyConn = new SqlConnection(strConn);
            //terceiro passo criar a instrução a executar
            string sqlString = "Select * from aspnet_Users Where aspnet_Users.UserName ='" + username+ "';";
            //crio o objecto que recebe os dados da base de dados
            SqlCommand Cmd_MostraRegistos = new SqlCommand(sqlString, MyConn);
            //cria o objecto que recebe os dados da base de dados
            SqlDataReader myReader;

            //abre a ligação à BD

            try
            {
                MyConn.Open();
                myReader = Cmd_MostraRegistos.ExecuteReader();
                myReader.Read();

                currentUser.Curso = myReader["Curso"].ToString();
                currentUser.BirthDate = myReader["BirthDate"].ToString();
                currentUser.Address = myReader["Adress"].ToString();
                currentUser.FullName =  myReader["FullName"].ToString();
                currentUser.userId = myReader["UserId"].ToString();



                myReader.Close();
            }catch(Exception e){
               

            }
            finally
            {
                MyConn.Close();
            }

            return currentUser;
        }



        public int newTopicId()
        {
            string max = null;
             var currentUser = new NeeitUser();
            //segundo passo crio a minha connection em modo connected
            SqlConnection MyConn = new SqlConnection(strConn);
            //terceiro passo criar a instrução a executar
            string sqlString =" Select MAX(TopicId) as TopicId from tbl_Topics";
            //crio o objecto que recebe os dados da base de dados
            SqlCommand Cmd_MostraRegistos = new SqlCommand(sqlString, MyConn);
            //cria o objecto que recebe os dados da base de dados
            SqlDataReader myReader;

            //abre a ligação à BD

            try
            {
                MyConn.Open();
                myReader = Cmd_MostraRegistos.ExecuteReader();
                myReader.Read();

                max =myReader["TopicId"].ToString();


                myReader.Close();
            }catch(Exception e){
               

            }
            finally
            {
                MyConn.Close();
            }
            if (max == "")
            {
                return 1;
            }
            return int.Parse(max);
            
        }
        public void newTopic(string topicTitle, string topicContent,string UserId)
        {
            //Atualiza os dados, na Base de Dados

            //obtém a "Connection String", lendo-a do web.config
            string strConn = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;

            //cria o objeto "Connection"
            SqlConnection MyConn = new SqlConnection(strConn);

            //define o comando SQL a executar
            string strSQL = "INSERT INTO tbl_Topics(TopicId,TopicTitle,TopicContent) Values (@TopicId,@topicTitle,@topicContent);INSERT INTO tbl_TopicsUsers(UserId,TopicId,date) values (@UserId,@TopicId,@date);";

            //cria o objeto "Command"
            SqlCommand MyCommand = new SqlCommand(strSQL, MyConn);

            //configura o Command
            MyCommand.Parameters.AddWithValue("@TopicId", newTopicId()+1);
            MyCommand.Parameters.AddWithValue("@topicTitle", topicTitle);
            MyCommand.Parameters.AddWithValue("@topicContent", topicContent);   
             MyCommand.Parameters.AddWithValue("@UserId",   UserId);
            MyCommand.Parameters.AddWithValue("@date", DateTime.Now);   
            try
            {
                //abre a ligação à BD
                MyConn.Open();

                //'carrega' o DataReader
                MyCommand.ExecuteNonQuery();
            }
            finally
            {
                MyConn.Close();
            }
        }












    }
}
