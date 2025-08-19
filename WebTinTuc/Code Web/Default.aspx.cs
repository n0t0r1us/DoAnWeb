using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection conn = new SqlConnection("server=(local);uid=sa;pwd=123;database=QuanLyTinTuc");//Khai báo quyền truy cập vào Hệ QT CSDL
            SqlDataAdapter adap = new SqlDataAdapter("select TenCM from ChuyenMuc", conn);//Khai báo dữ liệu cần lấy từ CSDL để hiển thị lên web
            DataSet dt = new DataSet();//Khai báo nơi chứa dữ liệu sẽ lấy về
            conn.Open();//Mở kết nối
            adap.Fill(dt);//Lấy dữ liệu
            conn.Close();//Đóng kết nối
            griChuyenMuc.DataSource=dt.Tables[0];//Khai báo nguồn dữ liệu load ra bảng
            griChuyenMuc.DataBind();//Nạp dữ liệu cho bảng từ nguồn trên
            lstChuyenMuc.DataSource = dt.Tables[0];
            lstChuyenMuc.DataBind();
        }
       
    }
}
