namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDayToCustomerInDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDay='02/06/1991' WHERE Id=0");
        }
        
        public override void Down()
        {
        }
    }
}
