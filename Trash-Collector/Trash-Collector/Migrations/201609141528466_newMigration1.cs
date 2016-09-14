namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "zipcode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "state", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email_Id", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "password", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Firstname", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email_Id", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "password", c => c.String());
            AlterColumn("dbo.Employees", "Email_Id", c => c.String());
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "Firstname", c => c.String());
            AlterColumn("dbo.Customers", "password", c => c.String());
            AlterColumn("dbo.Customers", "Email_Id", c => c.String());
            AlterColumn("dbo.Customers", "state", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Employees", "zipcode");
        }
    }
}
