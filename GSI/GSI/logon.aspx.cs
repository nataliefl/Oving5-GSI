using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GSI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private WebUserControl1 wuc;
        private Button btnLogin;
        private SqlConnection sqlConn;
        private SqlTransaction sqlTrans;
        private SqlCommand sqlCom;
        private SqlDataReader sqlReader;
 

        protected void Page_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(); 

            wuc = WebUserControl11;
            if (wuc != null && !IsPostBack)
            {
                btnLogin = (Button)wuc.FindControl("btnLogin");
                btnLogin.Click +=new EventHandler(btnLogin_Click);
            }
        }

        protected void btnLogin_Click (object sender, EventArgs e)
        {
            sqlConn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GSIDatabaseConnectionString"].ConnectionString; //Blæh
            sqlConn.Open();
            sqlCom = sqlConn.CreateCommand();
            sqlTrans = sqlConn.BeginTransaction();
            sqlCom.Transaction = sqlTrans;

            //Execute queries
            try
            {
                sqlCom.Parameters.AddWithValue("userName", wuc.User);
                sqlCom.Parameters.AddWithValue("passWord", wuc.Password);
                sqlCom.CommandText = "SELECT Users.User, Users.Password,Users.userRole WHERE Users.User=userName";
                sqlReader = sqlCom.ExecuteReader();
                string user = (String)sqlReader[0];
                
            }
            catch(Exception exc)
            {
                sqlTrans.Rollback();
            }
            finally
            {
            sqlConn.Close();
            sqlCom.Dispose();
            sqlTrans.Dispose();
            }
            //
      
           
        }
    }
}