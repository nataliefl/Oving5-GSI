using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSI
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private string user;
        public string User
        {
            set
            {
                user = value;
            }
            get
            {
                return user;
            }
        }
        private string hashPw;
        public string Password
        {
            set
            {
                hashPw = value.GetHashCode().ToString();

            }
            get
            {
                return hashPw;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User = txtUsername.Text;
            Password = txtPassword.Text;
        }
    }
}