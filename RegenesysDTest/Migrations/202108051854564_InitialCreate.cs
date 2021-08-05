namespace RegenesysDTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        IDNumber = c.String(nullable: false),
                        Nationality = c.String(),
                        Email = c.String(nullable: false),
                        CountryCode = c.String(),
                        PhoneNumber = c.String(),
                        DOB = c.String(),
                        DateStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
