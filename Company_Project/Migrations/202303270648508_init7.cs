namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Export_Permission", "customerName", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Export_Permission", "customerName");
        }
    }
}
