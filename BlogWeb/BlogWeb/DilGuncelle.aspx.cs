using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class DilGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            Txtid.Text = x.ToString();
            Txtid.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLDILLERTableAdapter dt= new DataSet1TableAdapters.TBLDILLERTableAdapter();
                TxtDil.Text = dt.DilGetir(Convert.ToInt16(x))[0].DIL;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDILLERTableAdapter dt = new DataSet1TableAdapters.TBLDILLERTableAdapter();
            dt.DilGuncelle(TxtDil.Text, Convert.ToInt16(Txtid.Text));
            Response.Redirect("DilListesi.Aspx");
        }

    }
}