using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class logistics_company_website_template_adeletevehicle_aspx : System.Web.UI.Page
{

    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            String str = "", pid = "", c = "", pd = "", r = "", ph = "";

            con = new SqlConnection(strcon);


            pid = Request.QueryString.Get(0);

            string s = "delete  from vehicles where id=" + "'" + pid + "'";







            SqlCommand cmd11 = new SqlCommand(s, con);



            con.Open();
            cmd11.ExecuteNonQuery();
            con.Close();

            Response.Write("<script>alert('Deleted ');window.location='adminpage.aspx';</script>");



        }
        catch (Exception ex)
        {

            Response.Write(ex);

        }
    }
}