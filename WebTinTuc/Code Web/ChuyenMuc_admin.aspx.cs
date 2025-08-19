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

public partial class ChuyenMuc_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//Nếu trang web được load lần đầu tiên thì nạp dữ liệu cho griChuyenMuc
        {
            griChuyenMuc.DataSource = TinTucDB.ChuyenMuc.DS();//Xác định nguồn dữ liệu cần hiển thị
            griChuyenMuc.DataBind();//Nạp dữ liệu từ nguồn đã chọn ở trên
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
        txtMaCM.Text = "";
        txtTenCM.Text = "";

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        //Thực hiện lệnh thêm dữ liệu vào CSDL
        TinTucDB.ChuyenMuc.Them(txtTenCM.Text);
        //Nạp lại dữ liệu cho danh sách
        griChuyenMuc.DataSource = TinTucDB.ChuyenMuc.DS();
        griChuyenMuc.DataBind();
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        //Thực hiện lệnh sửa
        TinTucDB.ChuyenMuc.Sua(byte.Parse(txtMaCM.Text),txtTenCM.Text);
        //Nạp lại dữ liệu cho danh sách
        griChuyenMuc.DataSource = TinTucDB.ChuyenMuc.DS();
        griChuyenMuc.DataBind();
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        //Thực hiện lệnh xóa
        TinTucDB.ChuyenMuc.Xoa(byte.Parse(txtMaCM.Text));
        //Nạp lại dữ liệu cho danh sách
        griChuyenMuc.DataSource = TinTucDB.ChuyenMuc.DS();
        griChuyenMuc.DataBind();
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void btnBoQua_Click(object sender, EventArgs e)
    {
        //Ẩn khung cập nhật, hiện nút "Thêm mới"
        pnlCapNhat.Visible = false;
        lbtnThemMoi.Visible = true;
    }
    protected void griChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Khi chọn 1 dòng từ danh sách thì đọc nội dung chi tiết dòng đó, hiển thị khung cập nhật, ẩn nút "Thêm mới" và nút "Thêm", hiện nút "Sửa" và nút "Xóa"
        TinTucDB.ChuyenMuc.CT(byte.Parse(griChuyenMuc.SelectedValue.ToString()));
        pnlCapNhat.Visible = true;
        lbtnThemMoi.Visible = false;
        btnThem.Visible = false;
        btnSua.Visible = true;
        btnXoa.Visible = true;
        //Gán giá trị dòng dữ liệu vừa đọc được vào các TextBox trong khung cập nhật
        txtMaCM.Text = TinTucDB.ChuyenMuc.MaCM.ToString();//Phải ép kiểu byte sang chuỗi bằng lệnh .ToString()
        txtTenCM.Text = TinTucDB.ChuyenMuc.TenCM;
    }
}
