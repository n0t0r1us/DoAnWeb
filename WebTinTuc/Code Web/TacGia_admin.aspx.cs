using System;
using System.Data;
using System.Data.SqlClient;//Thư viện chứa các đối tượng kết nối đến SQL Server - ADO.NET
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class TacGia_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//Nếu trang web được load lần đầu tiên thì nạp dữ liệu cho griChuyenMuc
        {
            griTacGia.DataSource = TinTucDB.TacGia.DS();
            griTacGia.DataBind();
        }

    }
    protected void lbtnThemMoi_Click(object sender, EventArgs e)
    {
        //Khi nhấn nút "Thêm mới" thì ẩn nút "Thêm mới", nút "Sửa" và nút "Xóa", hiển thị khung cập nhật và nút "Thêm"
        lbtnThemMoi.Visible = false;
        btnSua.Visible = false;
        btnXoa.Visible = false;
        pnlCapNhat.Visible = true;
        btnThem.Visible = true;
        //Xóa các nội dung cũ trên các TextBox trong khung cập nhật
        TextBox_Xoa();
    }
    protected void btnBoQua_Click(object sender, EventArgs e)
    {
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void griTacGia_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Khi chọn 1 dòng từ danh sách thì đọc nội dung chi tiết dòng đó, hiển thị khung cập nhật, ẩn nút "Thêm mới" và nút "Thêm", hiện nút "Sửa" và nút "Xóa"
        TinTucDB.TacGia.CT(short.Parse(griTacGia.SelectedValue.ToString()));
        pnlCapNhat.Visible = true;
        lbtnThemMoi.Visible = false;
        btnThem.Visible = false;
        btnSua.Visible = true;
        btnXoa.Visible = true;
        //Gán giá trị dòng dữ liệu vừa đọc được vào các TextBox trong khung cập nhật
        txtMaTG.Text = TinTucDB.TacGia.MaTG.ToString();
        txtHoTG.Text = TinTucDB.TacGia.HoTG;
        txtTenTG.Text = TinTucDB.TacGia.TenTG;
        txtButDanh.Text = TinTucDB.TacGia.ButDanh;
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        //Thực hiện lệnh thêm dữ liệu vào CSDL
        TinTucDB.TacGia.Them(txtHoTG.Text, txtTenTG.Text, txtButDanh.Text);
        //Nạp lại dữ liệu cho danh sách
        griTacGia.DataSource = TinTucDB.TacGia.DS();
        griTacGia.DataBind();
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        //Thực hiện lệnh sửa
        TinTucDB.TacGia.Sua(short.Parse(txtMaTG.Text), txtHoTG.Text, txtTenTG.Text, txtButDanh.Text);
        //Nạp lại dữ liệu cho danh sách
        griTacGia.DataSource = TinTucDB.TacGia.DS();
        griTacGia.DataBind();
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        //Thực hiện lệnh xóa
        TinTucDB.TacGia.Xoa(short.Parse(txtMaTG.Text));
        //Nạp lại dữ liệu cho danh sách
        griTacGia.DataSource = TinTucDB.TacGia.DS();
        griTacGia.DataBind();
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    void TextBox_Xoa()
    {
        txtMaTG.Text = "";
        txtHoTG.Text = "";
        txtTenTG.Text = "";
        txtButDanh.Text = "";
    }
}
