using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoaiMH_ad : System.Web.UI.Page
{
    LoaiMH lmh = new LoaiMH();//Tạo đối tượng lmh thuộc lớp LoaiMH  đã xây dựng trong file XuLy.cs

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack==false)//Nếu trang nạp lần đầu - nếu trang chưa nạp lại
        {
            griLoaiMH.DataSource = lmh.DanhSach();//Khai báo nguồn dữ liệu sẽ hiển thị lên gridView tên griLoaiMH
            griLoaiMH.DataBind();//Nạp dữ liệu từ nguồn đã khai báo
        }
    }
}