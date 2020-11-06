namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "birthday");
        }
    }
}
