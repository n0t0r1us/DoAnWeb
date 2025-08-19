using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;//Thư viện mới bổ sung để tương tác với CSDL
using System.Data.SqlClient;
using System.Web.UI.WebControls;//Thư viện mới bổ sung để thao tác với SQL Server
//Mỗi bảng trong CSDL, tạo 1 lớp cùng tên
public class LoaiMH
{
    //Khao báo các thuộc tính - tương ứng các cột trong bảng dữ liệu
    public byte MaLMH;
    public string TenLMH;
    //Xây dựng các phương thức cơ bản 
    public DataTable DanhSach() //Lấy dữ liệu từ CSDL để hiển thị lên ứng dụng (web)
    {
        SqlConnection conn = new SqlConnection("server=(LOCAL);uid=sa;pwd=123;database=DB_38D1269");//Khai báo quyền kết nối đến CSDL cần thao tác
        SqlDataAdapter da = new SqlDataAdapter("LoaiMH_DS", conn);//Bộ điều phối dữ liệu: lấy dữ liệu từ CSDL để chuẩn bị đưa lên trang web
        DataTable db = new DataTable();//Khai báo bảng chứa dữ liệu
        conn.Open();//Mở kết nối đến CSDL
        da.Fill(db);//Nạp dữ liệu vào bảng tạm db
        conn.Close();//Ngắt kết nối đến máyy chủ SQL Server
        return db;//Trả dữ liệu đã lấy để chuẩn bị load lên web
    }
}
    
