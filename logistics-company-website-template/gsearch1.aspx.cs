using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

public partial class logistics_company_website_template_gsearch1 : System.Web.UI.Page
{

    SqlConnection con;
    SqlConnection con1;
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        con = new SqlConnection(strcon);
        string pid = Request.QueryString.Get(0);


        TextBox8.Text=Session["logname"] .ToString();
        TextBox5.Text = Session["name"].ToString();

        TextBox6.Text = Session["mobile"].ToString();
        TextBox11.Text = Session["ad"].ToString();
        TextBox12.Text = Session["dl"].ToString();
        TextBox7.Text = Session["photo"].ToString();

        //Session["photo"] = photo;
        //Session["name"] = name;
        //Session["mobile"] = mobile;





        try
        {
            


            string s = "select * from vehicles where id=" + "'" + pid+ "'";


            con.Open();

            SqlCommand cmd1 = new SqlCommand(s, con);
            SqlDataReader reader;
            reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                TextBox3.Text = reader.GetString(0);
                TextBox4.Text = reader.GetString(4);
                TextBox13.Text = reader.GetString(5);
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

        ////////////////////////////////////////
        try
        {

            string s = "select * from BOOK ";
            con.Open();

            SqlCommand cmd1 = new SqlCommand(s, con);
            SqlDataReader reader;
            reader = cmd1.ExecuteReader();
            int ctr = 100;
            while (reader.Read())
            {
                ctr++;

            }
            reader.Close();
            con.Close();
            TextBox1.Text = ctr.ToString();
            TextBox2.Text = DateTime.Now.ToLongDateString();


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

            string s = "select * from vehicles where id= " + "'" + TextBox1.Text + "'";
            con.Open();

            SqlCommand cmd1 = new SqlCommand(s, con);
            //SqlDataReader reader;
            //reader = cmd1.ExecuteReader();
            //int ctr = 0;
            //while (reader.Read())
            //{
            //    ctr++;

            //}
            //reader.Close();
            //con.Close();
            //if (ctr == 0)
            //{

                s = "insert into BOOK values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o,@p)";
                cmd1 = new SqlCommand(s, con);

                cmd1.Parameters.Add("@a", TextBox1.Text);
                cmd1.Parameters.Add("@b", TextBox2.Text);
                cmd1.Parameters.Add("@c", TextBox3.Text);
                cmd1.Parameters.Add("@d", TextBox4.Text);
                cmd1.Parameters.Add("@e", TextBox5.Text);
                cmd1.Parameters.Add("@f", TextBox6.Text);
                cmd1.Parameters.Add("@g", TextBox7.Text);
                cmd1.Parameters.Add("@h", TextBox11.Text);
                cmd1.Parameters.Add("@i", TextBox12.Text);
                cmd1.Parameters.Add("@j", TextBox8.Text);
                cmd1.Parameters.Add("@k", TextBox9.Text);
                cmd1.Parameters.Add("@l", TextBox13.Text);
                cmd1.Parameters.Add("@m", DropDownList1.Text);
                cmd1.Parameters.Add("@n", Label3.Text);
                cmd1.Parameters.Add("@o", Label4.Text);
                cmd1.Parameters.Add("@p", "BOOKED");





               // con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                // Label1.Text = "Registered successfully";
                Response.Write("<script>alert('Registered successfully');window.location='guestpage.aspx';</script>");

                // TextBox6.Text = "";
                //TextBox2.Text = "";
                //TextBox3.Text = "";
                //TextBox4.Text = "";

                ////    TextBox5.Text = "";
                //TextBox1.Text = "";


           
           
            //Session["name"] = TextBox1.Text.Trim();
            //Session["address"] = TextBox6.Text.Trim();
            //Session["mobile"] = TextBox2.Text.Trim();
             Response.Redirect("http://localhost/emailphp2021/index.php?e="+TextBox8.Text+"&amt="+Label3.Text);
        

        }
        catch (Exception ex)
        {

            Label2.Text = ex.ToString();

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        double d = Convert.ToDouble(DropDownList1.Text);

        double amt = d * Convert.ToDouble(TextBox13.Text);

        Label3.Text = amt.ToString();
        Label4.Text = amt.ToString();

    }
}