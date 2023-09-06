using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

public partial class logistics_company_website_template_guestreg : System.Web.UI.Page
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

            string s = "select * from signup  where emailid=" + "'" + TextBox8.Text + "'";
            con.Open();

            SqlCommand cmd11 = new SqlCommand(s, con);
            SqlDataReader reader;
            reader = cmd11.ExecuteReader();
            int ctr = 100;
            while (reader.Read())
            {
                ctr++;

            }
            reader.Close();
            con.Close();



            //////////////////////////
            if (ctr == 100)
            {
                s = "insert into signup values(@a,@b,@c,@d,@e,@f,@g)";
                SqlCommand cmd1 = new SqlCommand(s, con);



                cmd1 = new SqlCommand(s, con);

                cmd1.Parameters.Add("@a", TextBox3.Text);
                cmd1.Parameters.Add("@b", TextBox4.Text);
                cmd1.Parameters.Add("@c", FileUpload1.FileName);
                cmd1.Parameters.Add("@d", TextBox6.Text);
                cmd1.Parameters.Add("@e", TextBox7.Text);
                cmd1.Parameters.Add("@f", TextBox8.Text);
                cmd1.Parameters.Add("@g", TextBox9.Text);
               




                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert(' Registrered Successfully');window.location='index.html';</script>");


                //TextBox1.Text = "";
                //TextBox2.Text = "";
                //txtUsername.Text = "";

                //  txtPassword.Text= "";
                //TextBox7.Text = "";


                //TextBox8.Text = "";
                //TextBox9.Text = "";

            }

            else
            {
                Response.Write("<script>alert('Already Registrered ');window.location='guestreg.aspx';</script>");
            }
        }
        catch (Exception ex)
        {

            Label1.Text = ex.ToString();

        }

        //Response.Write("<script>alert('Registratio Success ');window.location='index.html';</script>");
    }
    
}