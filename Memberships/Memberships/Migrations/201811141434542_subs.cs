namespace Memberships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscription",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Sescription = c.String(maxLength: 2048),
                        RegistrationCode = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscription");
        }
    }
}
