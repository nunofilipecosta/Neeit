using Neeit.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Neeit.Frontend.Forum
{
    public partial class NewTopic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var database = new DatabaseGateway();
            NeeitUser currentUser = database.GetUser(User.Identity.Name);

            database.newTopic(tb_Title.Text, tb_Content.Text,currentUser.userId);




        }
    }
}