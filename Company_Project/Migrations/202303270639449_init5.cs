namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Export_Permission", "Suppliers_SupplierID", "dbo.Suppliers");
            DropIndex("dbo.Export_Permission", new[] { "Suppliers_SupplierID" });
            DropColumn("dbo.Export_Permission", "Suppliers_SupplierID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Export_Permission", "Suppliers_SupplierID", c => c.Int());
            CreateIndex("dbo.Export_Permission", "Suppliers_SupplierID");
            AddForeignKey("dbo.Export_Permission", "Suppliers_SupplierID", "dbo.Suppliers", "SupplierID");
        }
    }
}
