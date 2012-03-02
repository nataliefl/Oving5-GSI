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
    public partial class WebForm3 : System.Web.UI.Page
    {
        private SqlConnection sqlConn;
        private SqlCommand sqlCom;
        private Button btRegister;
        private SqlDataReader sqlReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            btRegister = (Button)WebUserControl11.FindControl("btnLogin");
            btRegister.Click += new EventHandler(btnLogin_Click);
           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GSIDatabaseConnectionString"].ConnectionString; //Blæh
            sqlConn.Open();
            sqlCom = sqlConn.CreateCommand();
            try
            {
                sqlCom.Parameters.AddWithValue("@userName", WebUserControl11.User);
                sqlCom.Parameters.AddWithValue("@passWord", WebUserControl11.Password);
                sqlCom.CommandText = "SELECT Username FROM Users WHERE (Username=@userName)";
                sqlReader = sqlCom.ExecuteReader();
                sqlReader.Read();

                if (sqlReader.HasRows)
                {
                    lblSucceded.Text="User exists already, choose another username";
                }
                else
                {
                    sqlReader.Close();
                    sqlCom.CommandText = "INSERT INTO Users VALUES (@userName,@passWord,'user')";
                    sqlCom.ExecuteNonQuery();
                    lblSucceded.Text = "User " + WebUserControl11.User + " was created!";
                }

            }
            catch (Exception exc)
            {

            }
            finally
            {
                sqlReader.Close();
                sqlConn.Close();
                sqlCom.Dispose();
            }

        }
    }
}