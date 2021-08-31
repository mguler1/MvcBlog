namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "MailAdress", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "MailAdress");
        }
    }
}
