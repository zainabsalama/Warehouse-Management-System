namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomId = c.Int(nullable: false, identity: true),
                        CustomName = c.String(nullable: false),
                        Customphone = c.Int(nullable: false),
                        CustomFax = c.String(nullable: false, maxLength: 8000, unicode: false),
                        CustomEmail = c.String(nullable: false, maxLength: 200, unicode: false),
                        CustomWebsite = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomId);
            
            CreateTable(
                "dbo.Import_Permission",
                c => new
                    {
                        ImportCode = c.Int(nullable: false, identity: true),
                        ImportDate = c.DateTime(nullable: false, storeType: "date"),
                        ProductionDate = c.Int(nullable: false),
                        Expiry = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        ItemsCount = c.Int(nullable: false),
                        supplierId = c.Int(nullable: false),
                        StoreId = c.Int(nullable: false),
                        Customers_CustomId = c.Int(),
                    })
                .PrimaryKey(t => t.ImportCode)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.supplierId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customers_CustomId)
                .Index(t => t.ItemId)
                .Index(t => t.supplierId)
                .Index(t => t.StoreId)
                .Index(t => t.Customers_CustomId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false),
                        UOMeasure = c.String(nullable: false),
                        StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.Export_Permission",
                c => new
                    {
                        ExportCode = c.Int(nullable: false, identity: true),
                        ExportDate = c.DateTime(nullable: false, storeType: "date"),
                        ItemId = c.Int(nullable: false),
                        ItemsCount = c.Int(nullable: false),
                        supplierId = c.Int(nullable: false),
                        StoreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExportCode)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.supplierId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.supplierId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompName = c.String(),
                        Location = c.String(maxLength: 100, unicode: false),
                        CompManager = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transfer_Items",
                c => new
                    {
                        TransferItemId = c.Int(nullable: false, identity: true),
                        ProductionDate = c.DateTime(nullable: false, storeType: "date"),
                        Expiry = c.Int(nullable: false),
                        SourceStore = c.Int(nullable: false),
                        DestinationStore = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        InStore_Id = c.Int(),
                        OutStore_Id = c.Int(),
                        Store_Id = c.Int(),
                        Store_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.TransferItemId)
                .ForeignKey("dbo.Stores", t => t.InStore_Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.OutStore_Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id1)
                .Index(t => t.SupplierId)
                .Index(t => t.ItemId)
                .Index(t => t.InStore_Id)
                .Index(t => t.OutStore_Id)
                .Index(t => t.Store_Id)
                .Index(t => t.Store_Id1);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        SuppName = c.String(nullable: false),
                        Suppphone = c.Int(nullable: false),
                        SuppFax = c.String(nullable: false, maxLength: 8000, unicode: false),
                        SuppEmail = c.String(nullable: false, maxLength: 200, unicode: false),
                        SuppWebsite = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Import_Permission", "Customers_CustomId", "dbo.Customers");
            DropForeignKey("dbo.Import_Permission", "supplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Import_Permission", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Import_Permission", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Export_Permission", "supplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Export_Permission", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "Store_Id1", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Transfer_Items", "OutStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Transfer_Items", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Transfer_Items", "InStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Items", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Export_Permission", "ItemId", "dbo.Items");
            DropIndex("dbo.Transfer_Items", new[] { "Store_Id1" });
            DropIndex("dbo.Transfer_Items", new[] { "Store_Id" });
            DropIndex("dbo.Transfer_Items", new[] { "OutStore_Id" });
            DropIndex("dbo.Transfer_Items", new[] { "InStore_Id" });
            DropIndex("dbo.Transfer_Items", new[] { "ItemId" });
            DropIndex("dbo.Transfer_Items", new[] { "SupplierId" });
            DropIndex("dbo.Export_Permission", new[] { "StoreId" });
            DropIndex("dbo.Export_Permission", new[] { "supplierId" });
            DropIndex("dbo.Export_Permission", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "StoreId" });
            DropIndex("dbo.Import_Permission", new[] { "Customers_CustomId" });
            DropIndex("dbo.Import_Permission", new[] { "StoreId" });
            DropIndex("dbo.Import_Permission", new[] { "supplierId" });
            DropIndex("dbo.Import_Permission", new[] { "ItemId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Transfer_Items");
            DropTable("dbo.Stores");
            DropTable("dbo.Export_Permission");
            DropTable("dbo.Items");
            DropTable("dbo.Import_Permission");
            DropTable("dbo.Customers");
        }
    }
}
