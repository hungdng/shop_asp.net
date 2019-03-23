using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    LopDungChung ldc = new LopDungChung();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TEN_DANG_NHAP"] != null)
        {
            pnlLogin.Visible = false;
            Panel2.Visible = true;
            imgAvatar.ImageUrl = "./HinhAnh/TaiKhoan/" + Session["HINH_ANH"];
            lblname.Text = Session["HO_TEN"] + "(" + Session["TEN_DANG_NHAP"] + ")";
        }
        else
        {
            HttpCookie ck = Request.Cookies["dn"];
            if (ck != null)
            {
                pnlLogin.Visible = false;
                Panel2.Visible = true;
                imgAvatar.ImageUrl = "./HinhAnh/TaiKhoan/" + ck["HINH_ANH"];
                lblname.Text = ck["HO_TEN"] + "(" + ck["TEN_DANG_NHAP"] + ")";
            }
        }
        if (!IsPostBack)
        {
            grvLoaiHang.DataSource = ldc.docNhieuDuLieu("select * from loai_hang");
            grvLoaiHang.DataBind();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlDataReader dl = ldc.docNhieuDuLieu("select * from NGUOI_DUNG WHERE TEN_DANG_NHAP='" + txtUser.Text + "' AND MAT_KHAU='" + txtPassword.Text + "'");
        if (dl.Read())
        {
            Session["HO_TEN"] = dl["HO_TEN"];
            Session["HINH_ANH"] = dl["HINH_ANH"];
            Session["TEN_DANG_NHAP"] = dl["TEN_DANG_NHAP"];

            pnlLogin.Visible = false;
            Panel2.Visible = true;
            imgAvatar.ImageUrl = "./HinhAnh/TaiKhoan/" + Session["HINH_ANH"];
            lblname.Text = Session["HO_TEN"] + "(" + Session["TEN_DANG_NHAP"] + ")";

            if (CheckBox1.Checked)
            {
                HttpCookie ck = new HttpCookie("dn");
                ck["HO_TEN"] = Session["HO_TEN"] + "";
                ck["HINH_ANH"] = Session["HINH_ANH"] + "";
                ck["TEN_DANG_NHAP"] = Session["TEN_DANG_NHAP"] + "";
                ck.Expires = DateTime.Now.AddDays(5);
                Response.Cookies.Add(ck);
            }
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["HO_TEN"] = null;
        Session["HINH_ANH"] = null;
        Session["TEN_DANG_NHAP"] = null;
        pnlLogin.Visible = true;
        Panel2.Visible = false;
    }
}
