namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newerMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "zipcode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "zipcode", c => c.Int(nullable: false));
        }
    }
}
