using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChuyenMuc_admin1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            griChuyenMuc.DataSource = TinTucDB.ChuyenMuc.DS();//Xác định nguồn dữ liệu cần hiện thị
            griChuyenMuc.DataBind();//Thực hiện nạp dữ liệu từ nguồn đã chọn
        }
    }

    protected void btnThemMoi_Click(object sender, EventArgs e)
    {
        pnlCapNhat.Visible = true;
        btnSua.Visible = false;
        btnXoa.Visible = false;
    }

    protected void btnBoQua_Click(object sender, EventArgs e)
    {
        pnlCapNhat.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}