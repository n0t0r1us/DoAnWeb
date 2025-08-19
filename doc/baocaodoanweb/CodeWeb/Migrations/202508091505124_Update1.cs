namespace Web_61131562.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_AnhSP", "MatHang_MaMH", "dbo.tb_MatHang");
            DropIndex("dbo.tb_AnhSP", new[] { "MatHang_MaMH" });
            CreateTable(
                "dbo.tb_AnhMH",
                c => new
                    {
                        MaAMH = c.Int(nullable: false, identity: true),
                        MaMH = c.Int(nullable: false),
                        Anh = c.String(),
                        MacDinh = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaAMH)
                .ForeignKey("dbo.tb_MatHang", t => t.MaMH, cascadeDelete: true)
                .Index(t => t.MaMH);
            
            DropTable("dbo.tb_AnhSP");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.MaAMH);
            
            DropForeignKey("dbo.tb_AnhMH", "MaMH", "dbo.tb_MatHang");
            DropIndex("dbo.tb_AnhMH", new[] { "MaMH" });
            DropTable("dbo.tb_AnhMH");
            CreateIndex("dbo.tb_AnhSP", "MatHang_MaMH");
            AddForeignKey("dbo.tb_AnhSP", "MatHang_MaMH", "dbo.tb_MatHang", "MaMH");
        }
    }
}
