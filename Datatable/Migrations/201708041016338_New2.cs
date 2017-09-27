namespace Datatable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "Age", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "Age", c => c.Int(nullable: false));
        }
    }
}
