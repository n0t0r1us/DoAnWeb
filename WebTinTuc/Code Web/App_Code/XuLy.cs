using System;
using System.Data;
using System.Data.SqlClient;//Thư viện chứa các lớp SqlConnecttion, SqlDataAdapter...
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
namespace TinTucDB
{
    public static class DungChung
    {
        public static string ChuoiKetNoi = "server=(local)\\P3RC1V4L;uid=sa;pwd=6996;database=QuanLyTinTuc";
    }
    public static class ChuyenMuc
    {
        public static byte MaCM;
        public static string TenCM;
        public static void Them(string _TenCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("ChuyenMuc_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@TenCM", _TenCM);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Sua(byte _MaCM, string _TenCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("ChuyenMuc_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaCM", _MaCM);
            par = cmd.Parameters.AddWithValue("@TenCM", _TenCM);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Xoa(byte _MaCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("ChuyenMuc_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaCM", _MaCM);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable DS()
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("ChuyenMuc_DS", conn);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void CT(byte _MaCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("ChuyenMuc_CT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaCM", _MaCM);
            SqlDataReader readDt;
            conn.Open();
            readDt = cmd.ExecuteReader();
            if (readDt.Read())
            {
                MaCM = byte.Parse(readDt["MaCM"].ToString());//Ép kiểu từ chuỗi sang byte vì MaCM là kiểu byte, tương ứng tinyInt trong CSDL SQL Server
                TenCM = readDt["TenCM"].ToString();
            }
            conn.Close();
        }
    }
    public static class NhomTin
    {
        public static byte MaNT;
        public static string TenNT;
        public static byte MaCM;
        public static void Them(string _TenNT, byte _MaCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("NhomTin_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@TenNT", _TenNT);
            par = cmd.Parameters.AddWithValue("@MaCM", _TenNT);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Sua(byte _MaNT, string _TenNT, byte _MaCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("NhomTin_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaNT", _MaNT);
            par = cmd.Parameters.AddWithValue("@TenNT", _TenNT);
            par = cmd.Parameters.AddWithValue("@MaCM", _MaCM);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Xoa(byte _MaNT)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("NhomTin_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaNT", _MaNT);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void CT(byte _MaNT)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("NhomTin_CT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaNT", _MaNT);
            SqlDataReader readDt;
            conn.Open();
            readDt = cmd.ExecuteReader();
            if (readDt.Read())
            {
                MaNT = byte.Parse(readDt["MaNT"].ToString());
                TenNT = readDt["TenNT"].ToString();
                MaCM = byte.Parse(readDt["MaCM"].ToString());
            }
            conn.Close();
        }
        public static DataTable DS()
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("NhomTin_DS", conn);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable Theo_ChuyenMuc(byte _MaCM)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("NhomTin_Theo_ChuyenMuc", conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.AddWithValue("@MaCM", _MaCM);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
    }
    public static class TacGia
    {
        public static short MaTG;
        public static string HoTG;
        public static string TenTG;
        public static string ButDanh;
        public static void Them(string _HoTG, string _TenTG, string _ButDanh)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TacGia_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@HoTG", _HoTG);
            par = cmd.Parameters.AddWithValue("@TenTG", _TenTG);
            par = cmd.Parameters.AddWithValue("@ButDanh", _ButDanh);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Sua(short _MaTG, string _HoTG, string _TenTG, string _ButDanh)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TacGia_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaTG", _MaTG);
            par = cmd.Parameters.AddWithValue("@HoTG", _HoTG);
            par = cmd.Parameters.AddWithValue("@TenTG", _TenTG);
            par = cmd.Parameters.AddWithValue("@ButDanh", _ButDanh);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Xoa(short _MaTG)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TacGia_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaTG", _MaTG);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void CT(short _MaTG)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TacGia_CT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaTG", _MaTG);
            SqlDataReader readDt;
            conn.Open();
            readDt = cmd.ExecuteReader();
            if (readDt.Read())
            {
                MaTG = short.Parse(readDt["MaTG"].ToString());
                HoTG = readDt["HoTG"].ToString();
                TenTG = readDt["TenTG"].ToString();
                ButDanh = readDt["ButDanh"].ToString();
            }
            conn.Close();
        }
        public static DataTable DS()
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("TacGia_DS", conn);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
    }
    public static class TinTuc
    {
        public static string MaTT;
        public static string TieuDe;
        public static string TomTat;
        public static string ChiTiet;
        public static DateTime NgayDang;
        public static string AnhMH;
        public static byte MaNT;
        public static short MaTG;
        public static void Them(string _TieuDe, string _TomTat, string _ChiTiet, DateTime _NgayDang, string _AnhMH, byte _MaNT, short _MaTG)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TinTuc_Them", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@TieuDe", _TieuDe);
            par = cmd.Parameters.AddWithValue("@TomTat", _TomTat);
            par = cmd.Parameters.AddWithValue("@ChiTiet", _ChiTiet);
            par = cmd.Parameters.AddWithValue("@NgayDang", _NgayDang);
            par = cmd.Parameters.AddWithValue("@AnhMH", _AnhMH);
            par = cmd.Parameters.AddWithValue("@MaNT", _MaNT);
            par = cmd.Parameters.AddWithValue("@MaTG", _MaTG);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Sua(byte _MaTT, string _TieuDe, string _TomTat, string _ChiTiet, DateTime _NgayDang, string _AnhMH, byte _MaNT,short _MaTG)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TinTuc_Sua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaTT", _MaTT);
            par = cmd.Parameters.AddWithValue("@TieuDe", _TieuDe);
            par = cmd.Parameters.AddWithValue("@TomTat", _TomTat);
            par = cmd.Parameters.AddWithValue("@ChiTiet", _ChiTiet);
            par = cmd.Parameters.AddWithValue("@NgayDang", _NgayDang);
            par = cmd.Parameters.AddWithValue("@AnhMH", _AnhMH);
            par = cmd.Parameters.AddWithValue("@MaNT", _MaNT);
            par = cmd.Parameters.AddWithValue("@MaTG", _MaTG);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Xoa(string _MaTT)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TinTuc_Xoa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaTT", _MaTT);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void CT(string _MaTT)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand("TinTuc_CT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter par = new SqlParameter();
            par = cmd.Parameters.AddWithValue("@MaTT", _MaTT);
            SqlDataReader readDt;
            conn.Open();
            readDt = cmd.ExecuteReader();
            if (readDt.Read())
            {
                MaTT = readDt["MaTT"].ToString();
                TieuDe = readDt["TieuDe"].ToString();
                TomTat = readDt["TomTat"].ToString();
                ChiTiet = readDt["ChiTiet"].ToString();
                NgayDang = DateTime.Parse(readDt["NgayDang"].ToString());
                AnhMH = readDt["AnhMH"].ToString();
                MaNT = byte.Parse(readDt["MaNT"].ToString());
                MaTG = short.Parse(readDt["MaTG"].ToString());
            }
            conn.Close();
        }
        public static DataTable DS()
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("TinTuc_DS", conn);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable Theo_NhomTin(byte _MaNT)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("TinTuc_Theo_NhomTin", conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.AddWithValue("@MaNT", _MaNT);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable Theo_TacGia(short _MaTG)
        {
            SqlConnection conn = new SqlConnection(DungChung.ChuoiKetNoi);
            SqlDataAdapter adap = new SqlDataAdapter("TinTuc_Theo_TacGia", conn);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.AddWithValue("@MaTG", _MaTG);
            DataTable dt = new DataTable();
            conn.Open();
            adap.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}