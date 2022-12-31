using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace LMN_Electronics_Products
{
    public partial class product : System.Web.UI.Page
    {
        SqlConnection con;  

        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            string sql = "Data Server= localhost; Database= WFM_Construction_Management_System;Integrated Security = SSPI;";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM product",con);
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                gv_product.DataSource = dt;
                gv_product.DataBind();
            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                gv_product.DataSource = dt;
                gv_product.DataBind();
                gv_product.Rows[0].Cells.Clear();
                gv_product.Rows[0].Cells.Add(new TableCell());
                gv_product.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                gv_product.Rows[0].Cells[0].Text = "No Data Found ...!";
                gv_product.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
    }
}