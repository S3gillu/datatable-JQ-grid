namespace Datatable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "StartDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workers", "StartDate");
        }
    }
}
