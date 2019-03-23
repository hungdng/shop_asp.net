using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HangDetails : System.Web.UI.Page
{
    LopDungChung ldc = new LopDungChung();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            loadGrid();
    }

    private void loadGrid()
    {
        var id = Request.QueryString["id"];
        DetailsView1.DataSource = ldc.docNhieuDuLieu("select * from HANG_HOA WHERE MA_HANG='" + Request.QueryString["id"] + "'");
        DetailsView1.DataBind();
    }

    protected void btnLuuMoi_Click(object sender, EventArgs e)
    {
        string sql = "INSERT INTO PHAN_HOI(TIEU_DE, HO_TEN, LIEN_HE, NOI_DUNG)"
           + " VALUES(N'" + txtTieuDe.Text + "', N'" + txtTen.Text + "', N'" + txtLienHe.Text + "', N'" + txtNoiDung.Text + "')";
        if (ldc.xuLy(sql) == 1)
        {
            lblThongBao.Text = "Cảm ơn bạn đã gửi PHẢN HỒI";
            pnlPhanHoi.Visible = false;
        }            
        else
            lblThongBao.Text = "gửi phản hồi LỖI!";
    }
}