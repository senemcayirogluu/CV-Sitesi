using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class DilSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.TBLDILLERTableAdapter dt = new DataSet1TableAdapters.TBLDILLERTableAdapter();
            dt.DilSil(Convert.ToInt16(x));
            Response.Redirect("DilListesi.Aspx");
        }
    }
}