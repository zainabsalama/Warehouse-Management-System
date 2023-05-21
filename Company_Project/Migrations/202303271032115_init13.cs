namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Export_Permission", "customerId", "dbo.Customers");
            DropForeignKey("dbo.Import_Permission", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Transfer_Items", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Export_Permission", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "InStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "OutStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "Store_Id1", "dbo.Stores");
            DropForeignKey("dbo.Import_Permission", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Export_Permission", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Import_Permission", "supplierId", "dbo.Suppliers");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Export_Permission");
            DropPrimaryKey("dbo.Items");
            DropPrimaryKey("dbo.Import_Permission");
            DropPrimaryKey("dbo.Stores");
            DropPrimaryKey("dbo.Transfer_Items");
            DropPrimaryKey("dbo.Suppliers");
            AlterColumn("dbo.Customers", "CustomId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Export_Permission", "ExportCode", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Items", "Code", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Import_Permission", "ImportCode", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Transfer_Items", "TransferItemId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Suppliers", "SupplierID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "CustomId");
            AddPrimaryKey("dbo.Export_Permission", "ExportCode");
            AddPrimaryKey("dbo.Items", "Code");
            AddPrimaryKey("dbo.Import_Permission", "ImportCode");
            AddPrimaryKey("dbo.Stores", "Id");
            AddPrimaryKey("dbo.Transfer_Items", "TransferItemId");
            AddPrimaryKey("dbo.Suppliers", "SupplierID");
            AddForeignKey("dbo.Export_Permission", "customerId", "dbo.Customers", "CustomId", cascadeDelete: true);
            AddForeignKey("dbo.Import_Permission", "ItemId", "dbo.Items", "Code", cascadeDelete: true);
            AddForeignKey("dbo.Transfer_Items", "ItemId", "dbo.Items", "Code", cascadeDelete: true);
            AddForeignKey("dbo.Export_Permission", "ItemId", "dbo.Items", "Code", cascadeDelete: true);
            AddForeignKey("dbo.Items", "StoreId", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "InStore_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "OutStore_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "Store_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "Store_Id1", "dbo.Stores", "Id");
            AddForeignKey("dbo.Import_Permission", "StoreId", "dbo.Stores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Export_Permission", "StoreId", "dbo.Stores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transfer_Items", "SupplierId", "dbo.Suppliers", "SupplierID", cascadeDelete: true);
            AddForeignKey("dbo.Import_Permission", "supplierId", "dbo.Suppliers", "SupplierID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Import_Permission", "supplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Transfer_Items", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Export_Permission", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Import_Permission", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "Store_Id1", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "OutStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "InStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Items", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Export_Permission", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Transfer_Items", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Import_Permission", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Export_Permission", "customerId", "dbo.Customers");
            DropPrimaryKey("dbo.Suppliers");
            DropPrimaryKey("dbo.Transfer_Items");
            DropPrimaryKey("dbo.Stores");
            DropPrimaryKey("dbo.Import_Permission");
            DropPrimaryKey("dbo.Items");
            DropPrimaryKey("dbo.Export_Permission");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Suppliers", "SupplierID", c => c.Int(nullable: false));
            AlterColumn("dbo.Transfer_Items", "TransferItemId", c => c.Int(nullable: false));
            AlterColumn("dbo.Stores", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Import_Permission", "ImportCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Code", c => c.Int(nullable: false));
            AlterColumn("dbo.Export_Permission", "ExportCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Suppliers", "SupplierID");
            AddPrimaryKey("dbo.Transfer_Items", "TransferItemId");
            AddPrimaryKey("dbo.Stores", "Id");
            AddPrimaryKey("dbo.Import_Permission", "ImportCode");
            AddPrimaryKey("dbo.Items", "Code");
            AddPrimaryKey("dbo.Export_Permission", "ExportCode");
            AddPrimaryKey("dbo.Customers", "CustomId");
            AddForeignKey("dbo.Import_Permission", "supplierId", "dbo.Suppliers", "SupplierID", cascadeDelete: true);
            AddForeignKey("dbo.Transfer_Items", "SupplierId", "dbo.Suppliers", "SupplierID", cascadeDelete: true);
            AddForeignKey("dbo.Export_Permission", "StoreId", "dbo.Stores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Import_Permission", "StoreId", "dbo.Stores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transfer_Items", "Store_Id1", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "Store_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "OutStore_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Transfer_Items", "InStore_Id", "dbo.Stores", "Id");
            AddForeignKey("dbo.Items", "StoreId", "dbo.Stores", "Id");
            AddForeignKey("dbo.Export_Permission", "ItemId", "dbo.Items", "Code", cascadeDelete: true);
            AddForeignKey("dbo.Transfer_Items", "ItemId", "dbo.Items", "Code", cascadeDelete: true);
            AddForeignKey("dbo.Import_Permission", "ItemId", "dbo.Items", "Code", cascadeDelete: true);
            AddForeignKey("dbo.Export_Permission", "customerId", "dbo.Customers", "CustomId", cascadeDelete: true);
        }
    }
}
