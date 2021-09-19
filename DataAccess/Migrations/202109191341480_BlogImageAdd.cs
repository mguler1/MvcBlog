namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogImageAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogImage2", c => c.String());
            AddColumn("dbo.Blogs", "BlogImage3", c => c.String());
            AddColumn("dbo.Blogs", "BlogImage4", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogImage4");
            DropColumn("dbo.Blogs", "BlogImage3");
            DropColumn("dbo.Blogs", "BlogImage2");
        }
    }
}
