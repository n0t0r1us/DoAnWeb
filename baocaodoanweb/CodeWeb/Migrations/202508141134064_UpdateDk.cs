namespace Web_61131562.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_DangKy", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_DangKy", "Email", c => c.String());
        }
    }
}
