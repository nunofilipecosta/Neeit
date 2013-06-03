using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Neeit.Frontend
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateUserWizard1_CreatingUser1(object sender, LoginCancelEventArgs e)
        {
            System.Web.Security.Roles.AddUserToRole(CreateUserWizard1.UserName, "RegisteredUser");

         


            

        }

    }
}