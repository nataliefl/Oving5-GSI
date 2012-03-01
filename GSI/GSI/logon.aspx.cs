using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Security;

namespace GSI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private WebUserControl1 wuc;
        private Button btnLogin;
        private SqlConnection sqlConn;
        private SqlCommand sqlCom;
        private SqlDataReader sqlReader;
        
 
        protected  void Page_Init(object sender, EventArgs e)
        {
            wuc = WebUserControl11;
            btnLogin = (Button)wuc.FindControl("btnLogin");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection();          
           
            if (wuc != null )
            {
                btnLogin.Click += new EventHandler(btnLogin_Click);
            }
        }

        protected void btnLogin_Click (object sender, EventArgs e)
        {
            sqlConn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GSIDatabaseConnectionString"].ConnectionString; //Blæh
            sqlConn.Open();
            sqlCom = sqlConn.CreateCommand();


            //Execute queries
            try
            {
                sqlCom.Parameters.AddWithValue("@userName", wuc.User);
                sqlCom.Parameters.AddWithValue("@passWord", wuc.Password);
                sqlCom.CommandText = "SELECT Username,Password,userRole FROM Users WHERE (Username=@userName) AND Password=@passWord";
                sqlReader = sqlCom.ExecuteReader();
                sqlReader.Read();
                string user = (String)sqlReader["Username"];
                string pw = (String)sqlReader["Passoword"];
              
                
            }
            catch(Exception exc)
            {
               
            }
            finally
            {
            sqlReader.Close();
            sqlConn.Close();
            sqlCom.Dispose();
            }
            //
            //if (user == "test" && pw == "test")
            //{
            //    FormsAuthentication.RedirectFromLoginPage("test", true);
            //}
            //else
            //{
            //    Response.Redirect("logon.aspx", true);
            //}
           
        }
    }
}