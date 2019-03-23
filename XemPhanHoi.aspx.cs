using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class XemPhanHoi : System.Web.UI.Page
{
    LopDungChung ldc = new LopDungChung();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            loadGrid();
    }

    private void loadGrid()
    {
        GridView1.DataSource = ldc.docNhieuDuLieu("select * from PHAN_HOI");
        GridView1.DataBind();
    }
}