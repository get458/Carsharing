namespace AutoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AutoRent_Contract", "StartDate", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.AutoRent_Contract", "FinishDate", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.AutoRent_Passport", "IssueDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AutoRent_Passport", "IssueDate");
            DropColumn("dbo.AutoRent_Contract", "FinishDate");
            DropColumn("dbo.AutoRent_Contract", "StartDate");
        }
    }
}
