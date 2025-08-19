namespace Web_61131562.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_CaiDatHeThong",
                c => new
                    {
                        CaiDatKhoa = c.String(nullable: false, maxLength: 50),
                        CaiDatGiaTri = c.String(maxLength: 4000),
                        CaiDatMoTa = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.CaiDatKhoa);
            
            CreateTable(
                "dbo.tb_CTDH",
                c => new
                    {
                        MaCTDH = c.Int(nullable: false, identity: true),
                        MaDG = c.Int(nullable: false),
                        MaMH = c.Int(nullable: false),
                        Gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaCTDH)
                .ForeignKey("dbo.tb_DonGia", t => t.MaDG, cascadeDelete: true)
                .ForeignKey("dbo.tb_MatHang", t => t.MaMH, cascadeDelete: true)
                .Index(t => t.MaDG)
                .Index(t => t.MaMH);
            
            CreateTable(
                "dbo.tb_DonGia",
                c => new
                    {
                        MaDG = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        TenKH = c.String(nullable: false),
                        SDT = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        Email = c.String(),
                        TongTien = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuong = c.Int(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaDG);
            
            CreateTable(
                "dbo.tb_MatHang",
                c => new
                    {
                        MaMH = c.Int(nullable: false, identity: true),
                        TenMH = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(maxLength: 250),
                        CodeMatHang = c.String(maxLength: 50),
                        MoTa = c.String(),
                        ChiTiet = c.String(),
                        Anh = c.String(maxLength: 250),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GiaKM = c.Decimal(precision: 18, scale: 2),
                        SoLuong = c.Int(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        IsMHSale = c.Boolean(nullable: false),
                        IsMHNoiBat = c.Boolean(nullable: false),
                        IsMHBanChay = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        MaLMH = c.Int(nullable: false),
                        SeoTieuDe = c.String(maxLength: 250),
                        SeoMoTa = c.String(maxLength: 500),
                        SeoTuKhoa = c.String(maxLength: 250),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaMH)
                .ForeignKey("dbo.tb_LoaiMH", t => t.MaLMH, cascadeDelete: true)
                .Index(t => t.MaLMH);
            
            CreateTable(
                "dbo.tb_AnhSP",
                c => new
                    {
                        MaAMH = c.Int(nullable: false, identity: true),
                        MaSP = c.Int(nullable: false),
                        Anh = c.String(),
                        MacDinh = c.Boolean(nullable: false),
                        MatHang_MaMH = c.Int(),
                    })
                .PrimaryKey(t => t.MaAMH)
                .ForeignKey("dbo.tb_MatHang", t => t.MatHang_MaMH)
                .Index(t => t.MatHang_MaMH);
            
            CreateTable(
                "dbo.tb_LoaiMH",
                c => new
                    {
                        MaLMH = c.Int(nullable: false, identity: true),
                        TenLMH = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(nullable: false, maxLength: 150),
                        MoTa = c.String(),
                        Icon = c.String(maxLength: 250),
                        SeoTieuDe = c.String(maxLength: 250),
                        SeoMoTa = c.String(maxLength: 500),
                        SeoTuKhoa = c.String(maxLength: 250),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaLMH);
            
            CreateTable(
                "dbo.tb_DangKy",
                c => new
                    {
                        MaDK = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaDK);
            
            CreateTable(
                "dbo.tb_DanhMuc",
                c => new
                    {
                        MaDM = c.Int(nullable: false, identity: true),
                        TenDM = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(),
                        MoTa = c.String(),
                        SeoTieuDe = c.String(maxLength: 150),
                        SeoMoTa = c.String(maxLength: 250),
                        SeoTuKhoa = c.String(maxLength: 150),
                        IsActive = c.Boolean(nullable: false),
                        ViTri = c.Int(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaDM);
            
            CreateTable(
                "dbo.tb_GioiThieu",
                c => new
                    {
                        MaGT = c.Int(nullable: false, identity: true),
                        TieuDeGT = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(maxLength: 150),
                        MoTa = c.String(),
                        ChiTiet = c.String(),
                        Anh = c.String(maxLength: 250),
                        MaDM = c.Int(nullable: false),
                        SeoTieuDe = c.String(maxLength: 250),
                        SeoMoTa = c.String(maxLength: 500),
                        SeoTuKhoa = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaGT)
                .ForeignKey("dbo.tb_DanhMuc", t => t.MaDM, cascadeDelete: true)
                .Index(t => t.MaDM);
            
            CreateTable(
                "dbo.tb_TinTuc",
                c => new
                    {
                        MaTT = c.Int(nullable: false, identity: true),
                        TieuDeTT = c.String(nullable: false, maxLength: 150),
                        Alias = c.String(),
                        MoTa = c.String(),
                        ChiTiet = c.String(),
                        Anh = c.String(),
                        MaDM = c.Int(nullable: false),
                        SeoTieuDe = c.String(),
                        SeoMoTa = c.String(),
                        SeoTuKhoa = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaTT)
                .ForeignKey("dbo.tb_DanhMuc", t => t.MaDM, cascadeDelete: true)
                .Index(t => t.MaDM);
            
            CreateTable(
                "dbo.tb_LienHe",
                c => new
                    {
                        MaLH = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 150),
                        Email = c.String(maxLength: 150),
                        Website = c.String(),
                        TinNhan = c.String(maxLength: 4000),
                        DaDoc = c.Boolean(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaLH);
            
            CreateTable(
                "dbo.tb_QuangCao",
                c => new
                    {
                        MaQC = c.Int(nullable: false, identity: true),
                        TieuDeQC = c.String(nullable: false, maxLength: 150),
                        MoTa = c.String(maxLength: 500),
                        Anh = c.String(maxLength: 500),
                        LienKet = c.String(maxLength: 500),
                        Loai = c.Int(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.MaQC);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        SDT = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.tb_TinTuc", "MaDM", "dbo.tb_DanhMuc");
            DropForeignKey("dbo.tb_GioiThieu", "MaDM", "dbo.tb_DanhMuc");
            DropForeignKey("dbo.tb_MatHang", "MaLMH", "dbo.tb_LoaiMH");
            DropForeignKey("dbo.tb_CTDH", "MaMH", "dbo.tb_MatHang");
            DropForeignKey("dbo.tb_AnhSP", "MatHang_MaMH", "dbo.tb_MatHang");
            DropForeignKey("dbo.tb_CTDH", "MaDG", "dbo.tb_DonGia");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.tb_TinTuc", new[] { "MaDM" });
            DropIndex("dbo.tb_GioiThieu", new[] { "MaDM" });
            DropIndex("dbo.tb_AnhSP", new[] { "MatHang_MaMH" });
            DropIndex("dbo.tb_MatHang", new[] { "MaLMH" });
            DropIndex("dbo.tb_CTDH", new[] { "MaMH" });
            DropIndex("dbo.tb_CTDH", new[] { "MaDG" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.tb_QuangCao");
            DropTable("dbo.tb_LienHe");
            DropTable("dbo.tb_TinTuc");
            DropTable("dbo.tb_GioiThieu");
            DropTable("dbo.tb_DanhMuc");
            DropTable("dbo.tb_DangKy");
            DropTable("dbo.tb_LoaiMH");
            DropTable("dbo.tb_AnhSP");
            DropTable("dbo.tb_MatHang");
            DropTable("dbo.tb_DonGia");
            DropTable("dbo.tb_CTDH");
            DropTable("dbo.tb_CaiDatHeThong");
        }
    }
}
