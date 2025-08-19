namespace Web_61131562.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateThanhToan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_DonGia", "LoaiThanhToan", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_DonGia", "LoaiThanhToan");
        }
    }
}
