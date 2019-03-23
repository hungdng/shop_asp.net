using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QLHang : System.Web.UI.Page
{
    LopDungChung ldc = new LopDungChung();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadLoaiHang();
            loadGrid();
        }
    }

    private void loadLoaiHang()
    {
        DropDownList1.DataSource = ldc.docNhieuDuLieu("select * from LOAI_HANG");
        DropDownList1.DataValueField = "MA_LOAI_HANG";
        DropDownList1.DataTextField = "TEN_LOAI_HANG";
        DropDownList1.DataBind();
    }

    private void loadGrid()
    {
        GridView1.DataSource = ldc.docNhieuDuLieu("select * from HANG_HOA");
        GridView1.DataBind();
    }

    protected void btnLuuMoi_Click(object sender, EventArgs e)
    {
        String fileName = Guid.NewGuid()
            + (new System.IO.FileInfo(fudHinhAnh.FileName)).Extension;
        fudHinhAnh.SaveAs(Server.MapPath("./HinhAnh/HangHoa/") + fileName);

        string sql = "INSERT INTO HANG_HOA(MA_HANG,TEN_HANG, MA_LOAI_HANG, GIA_BAN, GIA_NHAP, THONG_SO, HINH_ANH)"
            + " VALUES('" + txtMaHang.Text + "','" + txtTenHang.Text + "', N'" + DropDownList1.SelectedValue + "', '" + txtGiaBan.Text + "', '" + txtGiaNhap.Text + "', '" + txtThuocTinh.Text + "', '" + fileName + "')";
        if (ldc.xuLy(sql) == 1)
            lblThongBao.Text = "Thêm mới hàng thành công";
        else
            lblThongBao.Text = "Thêm mới hàng LỖI!";

        loadGrid();
        clearData();
    }

    protected void Xoa_Click(object sender, EventArgs e)
    {
        string sql = "DELETE FROM HANG_HOA WHERE MA_HANG='" + ((Button)sender).CommandName + "'";
        if (ldc.xuLy(sql) == 1)
            lblThongBao.Text = "Xóa loại hàng thành công";
        else
            lblThongBao.Text = "Xóa loại hàng LỖI!";

        loadGrid();
    }

    protected void Chon_Click(object sender, EventArgs e)
    {
        string query = "SELECT * FROM HANG_HOA WHERE MA_HANG='"
            + ((Button)sender).CommandName + "'";
        System.Data.SqlClient.SqlDataReader
            d = ldc.docNhieuDuLieu(query);
        if (d.Read())
        {
            txtMaHang.Enabled = false;
            txtMaHang.Text = d["MA_HANG"] + "";
            txtTenHang.Text = d["TEN_HANG"] + "";
            txtGiaBan.Text = d["GIA_BAN"] + "";
            txtGiaNhap.Text = d["GIA_NHAP"] + "";
            txtThuocTinh.Text = d["THONG_SO"] + "";
            string value_str = d["MA_LOAI_HANG"] + "";
            DropDownList1.ClearSelection();
            DropDownList1.Items.FindByValue(value_str).Selected = true;
        }        
    }
    protected void btnThayDoi_Click(object sender, EventArgs e)
    {
        String fileName = Guid.NewGuid()
            + (new System.IO.FileInfo(fudHinhAnh.FileName)).Extension;
        fudHinhAnh.SaveAs(Server.MapPath("./HinhAnh/HangHoa/") + fileName);

        string sql = "UPDATE HANG_HOA SET TEN_HANG = N'" + txtTenHang.Text + "', MA_LOAI_HANG = '" + DropDownList1.SelectedValue + "', GIA_BAN = '" + txtGiaBan.Text + "', GIA_NHAP = '" + txtGiaNhap.Text + "', THONG_SO = N'" + txtThuocTinh.Text + "', HINH_ANH = '" + fileName + "' WHERE (MA_HANG = '" + txtMaHang.Text + "')";
        if (ldc.xuLy(sql) == 1)
        {
            lblThongBao.Text = "Cập nhật hàng hóa thành công";
        }
        else
            lblThongBao.Text = "Cập nhật hàng hóa thất bại";
        loadGrid();
        clearData();
    }

    private void clearData()
    {
        txtMaHang.Enabled = true;
        txtMaHang.Text = "";
        txtTenHang.Text = "";
        txtGiaBan.Text = "";
        txtGiaNhap.Text = "";
        txtThuocTinh.Text = "";
        DropDownList1.ClearSelection();
    }
}