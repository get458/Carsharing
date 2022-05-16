namespace AutoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AutoRent_User", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AutoRent_User", "Name");
        }
    }
}
