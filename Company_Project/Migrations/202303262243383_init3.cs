namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Import_Permission", "Customers_CustomId", "dbo.Customers");
            DropIndex("dbo.Import_Permission", new[] { "Customers_CustomId" });
            AddColumn("dbo.Export_Permission", "Customers_CustomId", c => c.Int());
            CreateIndex("dbo.Export_Permission", "Customers_CustomId");
            AddForeignKey("dbo.Export_Permission", "Customers_CustomId", "dbo.Customers", "CustomId");
            DropColumn("dbo.Import_Permission", "Customers_CustomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Import_Permission", "Customers_CustomId", c => c.Int());
            DropForeignKey("dbo.Export_Permission", "Customers_CustomId", "dbo.Customers");
            DropIndex("dbo.Export_Permission", new[] { "Customers_CustomId" });
            DropColumn("dbo.Export_Permission", "Customers_CustomId");
            CreateIndex("dbo.Import_Permission", "Customers_CustomId");
            AddForeignKey("dbo.Import_Permission", "Customers_CustomId", "dbo.Customers", "CustomId");
        }
    }
}
