using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;

namespace LMN_Electronics_Products
{
    public class Global : System.Web.HttpApplication
    {

        SqlConnection con;

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        public void dbConnect()
        {
            string sql = @"Data Server= localhost; Database= WFM_Construction_Management_System;Integrated Security = SSPI;";
            con = new SqlConnection(sql);
            con.Open();

        }
    }
}