using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class DilListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDILLERTableAdapter dt = new DataSet1TableAdapters.TBLDILLERTableAdapter();
            Repeater1.DataSource = dt.DilListesi();
            Repeater1.DataBind();
        }
    }
}