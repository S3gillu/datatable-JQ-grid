namespace Datatable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "Position", c => c.String());
            AlterColumn("dbo.Workers", "StartDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "StartDate", c => c.String(nullable: false));
            AlterColumn("dbo.Workers", "Position", c => c.String(nullable: false));
        }
    }
}
