using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

public partial class logistics_company_website_template_editproducts1 : System.Web.UI.Page
{

    SqlConnection con;
    SqlConnection con1;
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Request.QueryString.Get(0);
        try
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(strcon);


            string s = "select * from VEHICLES where id=" + "'" + TextBox1.Text + "'";


            con.Open();

            SqlCommand cmd1 = new SqlCommand(s, con);
            SqlDataReader reader;
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                //  TextBox1.Text = reader.GetString(0);
                //TextBox7.Text = reader.GetString(1);
                //TextBox3.Text = reader.GetString(2);
                //TextBox4.Text = reader.GetString(3);
                //TextBox5.Text = reader.GetString(4);
                //TextBox6.Text = reader.GetString(5);



            }
            reader.Close();
            con.Close();



        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {

            string s = "update VEHICLEs  set vtype=@a,vname=@b,vdesc=@c,photo=@d ,vcharges=@e where id=" + "'" + TextBox1.Text + "'";
            SqlCommand cmd11 = new SqlCommand(s, con);
            //cmd11.Parameters.Add("@a", TextBox1.Text);
            cmd11.Parameters.Add("@a", DropDownList1.Text);
            cmd11.Parameters.Add("@b", TextBox2.Text);
            cmd11.Parameters.Add("@c", TextBox3.Text);
            cmd11.Parameters.Add("@d", FileUpload1.FileName);
                 cmd11.Parameters.Add("@e", TextBox4.Text);
            con.Open();
            cmd11.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Vehicle Details Updated ');window.location='adminpage.aspx';</script>");

        }
        catch (Exception ex)
        {

            Label2.Text = ex.ToString();
        }

    }
}