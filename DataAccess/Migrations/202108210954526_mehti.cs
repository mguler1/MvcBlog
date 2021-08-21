namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mehti : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Mails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        MailAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MailId);
            
        }
    }
}
