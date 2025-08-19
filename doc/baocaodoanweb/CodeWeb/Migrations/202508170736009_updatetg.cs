namespace Web_61131562.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_TinTuc", "TacGia", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_TinTuc", "TacGia");
        }
    }
}
