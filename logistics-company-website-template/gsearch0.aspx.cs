using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

public partial class logistics_company_website_template_gsearch0 : System.Web.UI.Page
{



    SqlConnection con;
    SqlConnection con1;
    protected void Page_Load(object sender, EventArgs e)
    {




        string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        con = new SqlConnection(strcon);


        try
        {
           // DropDownList1.Items.Clear();

            string ss = "select distinct vtype from vehicles";
            // Response.Write(ss);

            con.Open();

            SqlCommand cmd1 = new SqlCommand(ss, con);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();

            String name = "";
            while (reader1.Read())
            {

                DropDownList1.Items.Add(reader1.GetString(0));


            }
            reader1.Close();
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

           // string em = Session["logname"].ToString();
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(strcon);


            string s = "select * from vehicles where vtype =" + "'" + DropDownList1.Text + "'";


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


            if (ctr > 0)
            {
                /////////////////////

                //  string str11 = "select * from payment2  where  email=" + "'" + ln + "'";
                // string str11 = "select * from packbooking";// where clientemail =" + "'" + em + "'";



                //ownerid,fname,phone from owner WHERE ownerid =" + "'" + txtowner.Text + "'";
                con.Open();
                SqlCommand cmd2 = new SqlCommand(s, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(cmd2);
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                con.Close();


                //////////////////////////////////////////////////////////////
                ///

                //   string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                //  con = new SqlConnection(strcon);

                
              
            }
            else
            {
                Label1.Text = "Sorry No Order details yet...";
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.ToString();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("gsearch.aspx?sel=" + DropDownList1.Text);
    }
}