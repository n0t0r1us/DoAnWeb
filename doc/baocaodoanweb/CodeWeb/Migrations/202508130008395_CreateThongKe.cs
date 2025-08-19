namespace Web_61131562.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateThongKe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_ThongKe",
                c => new
                    {
                        MaTK = c.Int(nullable: false, identity: true),
                        ThoiGian = c.DateTime(nullable: false),
                        SoTruyCap = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.MaTK);
            
            AddColumn("dbo.tb_MatHang", "LuotXem", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_MatHang", "LuotXem");
            DropTable("dbo.tb_ThongKe");
        }
    }
}
