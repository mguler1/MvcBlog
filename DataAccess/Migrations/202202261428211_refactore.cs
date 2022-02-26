namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "PhoneNumber", c => c.String(maxLength: 20));
            AddColumn("dbo.Authors", "AboutShort", c => c.String(maxLength: 250));
            AddColumn("dbo.Categories", "CategoryStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryStatus");
            DropColumn("dbo.Authors", "AboutShort");
            DropColumn("dbo.Authors", "PhoneNumber");
            DropColumn("dbo.Authors", "AuthorTitle");
        }
    }
}
