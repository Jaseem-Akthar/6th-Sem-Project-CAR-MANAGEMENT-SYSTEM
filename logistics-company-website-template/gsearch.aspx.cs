using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration; 
public partial class logistics_company_website_template_gsearch : System.Web.UI.Page
{

    SqlConnection con;
    SqlConnection con1;
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {

            String sel = Request.QueryString.Get(0);
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(strcon);
            // string ln = Session["logname"].ToString();
            String str = "select *  from vehicles where vtype="+ "'" + sel + "'";
            SqlCommand cm = new SqlCommand(str, con);
            SqlDataReader reader;
            con.Open();
            Response.Write("<h1 align=center><a href=guestpage.aspx>Home</a></h1>");

            Response.Write("<br><br><br><br><br><br><table id=customers align=center border=5><tr><td>VEHICLE NO</td><td>VEHICLE TYPE</td>            <td>VEHICLE NAME</td><td>VEHICLE DESC</td><td>PHOTO</td><td>CHARGES/DAY</td><td>STATUS</td><td>ACTION</td></tr><tr>");
            reader = cm.ExecuteReader();
            String s = "", pid = "";
            while (reader.Read())
            {
                for (int i = 0; i <= 6; i++)
                {
                    s = reader.GetString(i).Trim();
                    if (i == 4)
                    {
                        //Response.Write(s);
                        Response.Write("<td><img src=" + s + " width=100 height=100 ></img></td>");
                        //    Response.Write("<td><a href=addtocart.aspx?id=" + s + " >Add to Cart</a></td>");
                    }
                    else if (i == 0)
                    {
                        pid = s;
                        Response.Write("<td>" + s + " </td>");


                    }
                    else
                    {

                        Response.Write("<td>" + s + " </td>");


                    }


                }
                Response.Write("<td><a href=gsearch1.aspx?id=" + pid + " >BOOK THIS</a>&nbsp;&nbsp;&nbsp;&nbsp;");
           //     Response.Write("<a href=deleteproducts.aspx?id=" + pid + " >DELETE PRODUCT</a></td>");
                //    Response.Write("<td><a href=Deletebook.aspx?id=" + pid + " ><img src=delete.jpg height=50 width=50></img></a></td>");
                // Response.Write("<td><a href=Editbook.aspx?id="+" class=btn btn-info btn-lg>       <span class=glyphicon glyphicon-pencil></span> Edit     </a></td>");
                //  Response.Write("<td><a href=deletebook.aspx?id=" + s + " >Delete</a></td>");
                //   Response.Write("<td><a href=Viewcommentsmainpage1.aspx?u=" + s + ">Download<a/></td>");

                Response.Write("</tr>");
            }
            Response.Write("</table>");
            // Response.Write("<a href=homepage.aspx> back </a>");
            con.Close();

        }
        catch (Exception ex)
        {
            // Label1.Text = ex.ToString();
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}