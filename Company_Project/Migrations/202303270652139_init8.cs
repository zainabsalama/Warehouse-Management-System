namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Export_Permission", "customerName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Export_Permission", "customerName", c => c.Int(nullable: false));
        }
    }
}
