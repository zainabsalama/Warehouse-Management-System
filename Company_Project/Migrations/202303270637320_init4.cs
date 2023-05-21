namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Export_Permission", "Customers_CustomId", "dbo.Customers");
            DropForeignKey("dbo.Export_Permission", "supplierId", "dbo.Suppliers");
            DropIndex("dbo.Export_Permission", new[] { "supplierId" });
            DropIndex("dbo.Export_Permission", new[] { "Customers_CustomId" });
            RenameColumn(table: "dbo.Export_Permission", name: "Customers_CustomId", newName: "customerId");
            RenameColumn(table: "dbo.Export_Permission", name: "supplierId", newName: "Suppliers_SupplierID");
            AlterColumn("dbo.Export_Permission", "Suppliers_SupplierID", c => c.Int());
            AlterColumn("dbo.Export_Permission", "customerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Export_Permission", "customerId");
            CreateIndex("dbo.Export_Permission", "Suppliers_SupplierID");
            AddForeignKey("dbo.Export_Permission", "customerId", "dbo.Customers", "CustomId", cascadeDelete: true);
            AddForeignKey("dbo.Export_Permission", "Suppliers_SupplierID", "dbo.Suppliers", "SupplierID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Export_Permission", "Suppliers_SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Export_Permission", "customerId", "dbo.Customers");
            DropIndex("dbo.Export_Permission", new[] { "Suppliers_SupplierID" });
            DropIndex("dbo.Export_Permission", new[] { "customerId" });
            AlterColumn("dbo.Export_Permission", "customerId", c => c.Int());
            AlterColumn("dbo.Export_Permission", "Suppliers_SupplierID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Export_Permission", name: "Suppliers_SupplierID", newName: "supplierId");
            RenameColumn(table: "dbo.Export_Permission", name: "customerId", newName: "Customers_CustomId");
            CreateIndex("dbo.Export_Permission", "Customers_CustomId");
            CreateIndex("dbo.Export_Permission", "supplierId");
            AddForeignKey("dbo.Export_Permission", "supplierId", "dbo.Suppliers", "SupplierID", cascadeDelete: true);
            AddForeignKey("dbo.Export_Permission", "Customers_CustomId", "dbo.Customers", "CustomId");
        }
    }
}
