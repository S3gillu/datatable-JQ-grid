namespace Datatable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "Position", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "Position", c => c.String());
        }
    }
}
