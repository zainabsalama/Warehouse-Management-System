namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init10 : DbMigration
    {
        public override void Up()
        {
            // Drop primary key constraint
            DropPrimaryKey("dbo.Export_Permission");

            // Remove identity property from ExportCode column
            AlterColumn("dbo.Export_Permission", "ExportCode", c => c.Int(nullable: false));

            // Add new primary key constraint on ExportCode column
            AddPrimaryKey("dbo.Export_Permission", "ExportCode");
        }
        
        public override void Down()
        {
        }
    }
}
