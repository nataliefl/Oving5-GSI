using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace GSI.Secure
{
    public partial class Teams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSelectSport.SelectedIndexChanged += new EventHandler(ddlSelectSport_SelectedIndexChanged);
        }

        public void ddlSelectSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = "'" + ddlSelectSport.SelectedValue + "'";
            SqlDataAdapter dad = new SqlDataAdapter("Select Fornavn,Etternavn FROM medlemmer INNER JOIN Sport ON medlemmer.idMedlemmer=Sport.idMedlemmer AND Sport.Navn=" + choice,
               WebConfigurationManager.ConnectionStrings["GSIDatabaseConnectionString"].ConnectionString);
            DataTable dtblMembers = new DataTable();
            dad.Fill(dtblMembers);


            gv1.DataSource = dtblMembers;
            gv1.DataBind();
        }
    }

}