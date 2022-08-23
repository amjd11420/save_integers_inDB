using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
 

namespace int_inDB
{
    public partial class Int_InDB1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_id_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

            SqlDataSource1.Insert();
        }

        protected void view_id_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

            if (dv.Count > 0)
            {
                txt_id.Text = dv[0].Row["integers"].ToString();
            }
        }
    }
}