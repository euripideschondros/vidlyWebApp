namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET birthday='11/01/1990' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}