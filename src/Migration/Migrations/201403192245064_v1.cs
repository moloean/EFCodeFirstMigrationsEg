namespace Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        IdentityNumber = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.IdentityNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
