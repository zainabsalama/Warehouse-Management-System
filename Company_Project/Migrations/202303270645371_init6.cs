namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Export_Permission", "StoreName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Export_Permission", "StoreName");
        }
    }
}
