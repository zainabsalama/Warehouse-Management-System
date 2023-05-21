namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Import_Permission", "supplierName", c => c.String());
            AddColumn("dbo.Import_Permission", "StoreName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Import_Permission", "StoreName");
            DropColumn("dbo.Import_Permission", "supplierName");
        }
    }
}
