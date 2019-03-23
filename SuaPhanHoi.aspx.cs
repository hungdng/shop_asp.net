using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuaPhanHoi : System.Web.UI.Page
{
    LopDungChung ldc = new LopDungChung();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            loadData();
    }

    private void loadData()
    {
        var id = Request.QueryString["id"];
        SqlDataReader result = ldc.docNhieuDuLieu("select * from PHAN_HOI WHERE ID='" + id + "'");
        if (result.Read())
        {
            txtTieuDe.Text = result["TIEU_DE"] + "";
            txtTen.Text = result["HO_TEN"] + "";
            txtLienHe.Text = result["LIEN_HE"] + "";
            txtNoiDung.Text = result["NOI_DUNG"] + "";
        }
    }

    protected void btnLuu_Click(object sender, EventArgs e)
    {
        var id = Request.QueryString["id"];
        string sql = "UPDATE PHAN_HOI SET TIEU_DE = N'" + txtTieuDe.Text + "', HO_TEN = N'" + txtTen.Text + "', "
            + "LIEN_HE = N'" + txtLienHe.Text + "', NOI_DUNG = N'" + txtNoiDung.Text + "' WHERE ID = '"+id+"'";
        if (ldc.xuLy(sql) == 1)
        {
            //lblThongBao.Text = "Cảm ơn bạn đã gửi PHẢN HỒI";
            Response.Redirect("XemPhanHoi.aspx");
        }
        else
            lblThongBao.Text = "sửa phản hồi LỖI!";
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("XemPhanHoi.aspx");
    }
}