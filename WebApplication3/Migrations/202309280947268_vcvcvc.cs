namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vcvcvc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCat = c.Int(nullable: false, identity: true),
                        NameCat = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdCat);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
