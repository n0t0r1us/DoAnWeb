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

public partial class NhomTin_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//Nếu trang web được load lần đầu tiên thì nạp dữ liệu cho droChuyenMuc
        {
            droChuyenMuc.DataSource = TinTucDB.ChuyenMuc.DS();//Khai báo nguồn dữ liệu load ra bảng
            droChuyenMuc.DataBind();//Nạp dữ liệu cho dropdownlist từ nguồn trên
            droChuyenMuc.Items.Insert(0, new ListItem("---Chọn---", "0"));
        }
    }
    protected void griNhomTin_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void droChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
    {
        griNhomTin.DataSource = TinTucDB.NhomTin.Theo_ChuyenMuc(byte.Parse(droChuyenMuc.SelectedValue));//Khai báo nguồn dữ liệu load ra bảng
        griNhomTin.DataBind();//Nạp dữ liệu cho dropdownlist từ nguồn trên

    }
}
