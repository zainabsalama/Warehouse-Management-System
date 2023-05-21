namespace Company_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init9 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [Export_Permission] ON");
            Sql("ALTER TABLE [Export_Permission] ALTER COLUMN [ExportCode] [int] NOT NULL");
            Sql("SET IDENTITY_INSERT [Export_Permission] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
