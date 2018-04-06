namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        isSubscribedToNewsLetter = c.Boolean(nullable: false),
                        MembershipId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MemberType", t => t.MembershipId, cascadeDelete: true)
                .Index(t => t.MembershipId);
            
            CreateTable(
                "dbo.MemberType",
                c => new
                    {
                        MembershipId = c.Byte(nullable: false),
                        SignupFee = c.Short(nullable: false),
                        Durationinmonths = c.Byte(nullable: false),
                        Discountrate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.customers", "MembershipId", "dbo.MemberType");
            DropIndex("dbo.customers", new[] { "MembershipId" });
            DropTable("dbo.Movies");
            DropTable("dbo.MemberType");
            DropTable("dbo.customers");
        }
    }
}
