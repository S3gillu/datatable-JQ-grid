namespace Datatable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        OfficeId = c.Int(nullable: false, identity: true),
                        OfficePlace = c.String(nullable: false, maxLength: 200),
                        StartDate = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OfficeId);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Position = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 255),
                        OfficeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Offices", t => t.OfficeId, cascadeDelete: true)
                .Index(t => t.OfficeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "Office_OfficeId", "dbo.Offices");
            DropIndex("dbo.Workers", new[] { "Office_OfficeId" });
            DropTable("dbo.Workers");
            DropTable("dbo.Offices");
        }
    }
}
