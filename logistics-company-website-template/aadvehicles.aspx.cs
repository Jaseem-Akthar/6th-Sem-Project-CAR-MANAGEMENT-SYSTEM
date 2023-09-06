using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

public partial class logistics_company_website_template_aadvehicles : System.Web.UI.Page
{

    SqlConnection con;
    SqlConnection con1;
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        con = new SqlConnection(strcon);


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string s = "select * from vehicles where id= " + "'" + TextBox1.Text + "'";
            con.Open();

            SqlCommand cmd1 = new SqlCommand(s, con);
            SqlDataReader reader;
            reader = cmd1.ExecuteReader();
            int ctr = 0;
            while (reader.Read())
            {
                ctr++;

            }
            reader.Close();
            con.Close();
            if (ctr == 0)
            {

                s = "insert into vehicles values(@a,@b,@c,@d,@e,@f,@g)";
                cmd1 = new SqlCommand(s, con);

                cmd1.Parameters.Add("@a", TextBox1.Text);
                cmd1.Parameters.Add("@b", DropDownList1.Text);
                cmd1.Parameters.Add("@c", TextBox2.Text);
                cmd1.Parameters.Add("@d", TextBox3.Text);
                cmd1.Parameters.Add("@e", FileUpload1.FileName);
                cmd1.Parameters.Add("@f", TextBox4.Text);
                cmd1.Parameters.Add("@g", "AVAILABLE");





                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                // Label1.Text = "Registered successfully";
                Response.Write("<script>alert('Registered successfully');window.location='adminpage.aspx';</script>");

                // TextBox6.Text = "";
                //TextBox2.Text = "";
                //TextBox3.Text = "";
                //TextBox4.Text = "";

                ////    TextBox5.Text = "";
                //TextBox1.Text = "";


            }
            else
            {
                // Label1.Text = "You have already registered with us..";
                Response.Write("<script>alert('Already Registered ');window.location='aadvehicles.aspx';</script>");
            }
            //Session["name"] = TextBox1.Text.Trim();
            //Session["address"] = TextBox6.Text.Trim();
            //Session["mobile"] = TextBox2.Text.Trim();


        }
        catch (Exception ex)
        {

            Label2.Text = ex.ToString();

        }
    }
}