﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration; 


public partial class logistics_company_website_template_guestlogin : System.Web.UI.Page
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
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(strcon);


            string s = "select * from SIGNUP where emailID=" + "'" + TextBox1.Text + "'" + " and  password=" + "'" + TextBox2.Text + "'";


            con.Open();

            SqlCommand cmd1 = new SqlCommand(s, con);
            SqlDataReader reader;
            reader = cmd1.ExecuteReader();
            int ctr = 0;
            String photo = "", name = "", mobile = "", ad = "", dl = "";
            while (reader.Read())
            {
                ctr++;
                name = reader.GetString(0);
                mobile = reader.GetString(1);
                photo = reader.GetString(2);
                    ad = reader.GetString(3);
                 dl = reader.GetString(4);

            }
            reader.Close();
            con.Close();
            if (ctr == 1)
            {
                // Label1.Text = "success";
                Session["logname"] = TextBox1.Text.Trim();
                Session["photo"] = photo;
                Session["name"] = name;
                Session["mobile"] = mobile;
                Session["ad"] = ad;
                Session["dl"] = dl;
                Response.Write("<script>alert('Login Success ');window.location='guestpage.aspx';</script>");
                // Response.Redirect("adminhomepage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login Failed ');window.location='guestlogin.aspx';</script>");
            }


        }
        catch (Exception ex)
        {

            // lblMessage.Text = ex.ToString();
            Label1.Text = ex.ToString();
        }
    }
}