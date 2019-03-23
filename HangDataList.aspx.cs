using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HangDataList : System.Web.UI.Page
{
    LopDungChung ldc = new LopDungChung();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            loadGrid();
    }

    private void loadGrid()
    {
        if (Request.QueryString["id"] + "" != "")
            DataList1.DataSource = ldc.docNhieuDuLieu("select * from HANG_HOA WHERE MA_LOAI_HANG='" + Request.QueryString["id"] + "'");
        else
            DataList1.DataSource = ldc.docNhieuDuLieu("select * from HANG_HOA");
        DataList1.DataBind();
    }

    protected void Mua_Click(object sender, EventArgs e)
    {
        DataTable dt;
        if (Session["Gio"] == null)
        {
            //Tao gio hang moi
            dt = new DataTable();
            dt.Columns.Add("MA_HANG", typeof(string));
            dt.Columns.Add("TEN_HANG", typeof(string));
            dt.Columns.Add("HINH_ANH", typeof(string));
            dt.Columns.Add("DON_GIA", typeof(int));
            dt.Columns.Add("SO_LUONG", typeof(int));
            dt.Columns.Add("THANH_TIEN", typeof(int), "SO_LUONG*DON_GIA");
        }
        else
            dt = (DataTable)Session["Gio"];

        //Them vao gio
        string ma = ((Button)sender).CommandArgument;
        System.Data.SqlClient.SqlDataReader a =
            ldc.docNhieuDuLieu("SELECT * FROM HANG_HOA WHERE MA_HANG='" + ma + "'");
        if (a.Read())
        {
            DataRow r = dt.NewRow();
            r["MA_HANG"] = a["MA_HANG"];
            r["TEN_HANG"] = a["TEN_HANG"];
            r["HINH_ANH"] = a["HINH_ANH"];
            r["SO_LUONG"] = 1;
            r["DON_GIA"] = a["GIA_BAN"];
            dt.Rows.Add(r);
        }
        Session["Gio"] = dt;
    }
}