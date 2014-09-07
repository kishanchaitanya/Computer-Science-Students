using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;


public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int radio1 = 0;
        int radio2 = 0;
        int radio3 = 0;
        //string prem=Server.MapPath("~/db1.xlsx");
        string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Inetpub\vhosts\omputersciencestudents.com\httpdocs\db1.xlsx; Extended Properties='Excel 8.0;HDR=YES;'";
      
        OleDbConnection conn = new OleDbConnection(szConn);
        string name = Convert.ToString(TextBox1.Text);
        string rollno = Convert.ToString(TextBox2.Text);
        string dept = Convert.ToString(DropDownList1.Text);   
        string country = Convert.ToString(RadioButtonList1.Text);
        string country2 = Convert.ToString(RadioButtonList2.Text);
        string country3= Convert.ToString(RadioButtonList3.Text);

        if (dept == "ME")
        {
            
            if (country == "India")
            {
                radio1++;

            }
            else if (country == "Australia")
            {
                radio2++;
            }
            else
            {
                radio3++;
            }


            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Sheet1$]([Name],[Roll No],[Department],[Radio1],[Radio2],[Radio3]) VALUES('" + name + "','" + rollno + "','" + dept + "','" + radio1 + "','" + radio2 + "','" + radio3 + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (dept == "MCA")
        {
         
            if (country2 == "India2")
            {
                radio1++;


            }
            else if (country2 == "Australia2")
            {
                radio2++;
            }
            else
            {
                radio3++;
            }


            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Sheet2$]([Name],[Roll No],[Department],[Radio1],[Radio2],[Radio3]) VALUES('" + name + "','" + rollno + "','" + dept + "','" + radio1 + "','" + radio2 + "','" + radio3 + "')", conn);
            cmd.ExecuteNonQuery();


            conn.Close();
        }
        else
        {
           
            if (country3 == "India3")
            {
                radio1++;


            }
            else if (country3 == "Australia3")
            {
                radio2++;
            }
            else
            {
                radio3++;
            }

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Sheet3$]([Name],[Roll No],[Department],[Radio1],[Radio2],[Radio3]) VALUES('" + name + "','" + rollno + "','" + dept + "','" + radio1 + "','" + radio2 + "','" + radio3 + "')", conn);
            cmd.ExecuteNonQuery();


            conn.Close();
        }
      
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string dept = Convert.ToString(DropDownList1.Text);
        if (dept == "ME")
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;

        }
        else if (dept == "MCA")
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
        }     

    }
}