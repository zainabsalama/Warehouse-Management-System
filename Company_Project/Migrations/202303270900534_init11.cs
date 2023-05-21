namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init11 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Export_Permission");
            AlterColumn("dbo.Export_Permission", "ExportCode", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Export_Permission", "ExportCode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Export_Permission");
            AlterColumn("dbo.Export_Permission", "ExportCode", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Export_Permission", "ExportCode");
        }
    }
}
