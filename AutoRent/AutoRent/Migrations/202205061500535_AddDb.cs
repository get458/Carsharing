namespace AutoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AutoRent_Car",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        PriceForContract = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeID = c.Int(),
                        FuelID = c.Int(),
                        TransmissionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AutoRent_Fuel", t => t.FuelID)
                .ForeignKey("dbo.AutoRent_Transmission", t => t.TransmissionID, cascadeDelete: true)
                .ForeignKey("dbo.AutoRent_Type", t => t.TypeID)
                .Index(t => t.TypeID)
                .Index(t => t.FuelID)
                .Index(t => t.TransmissionID);
            
            CreateTable(
                "dbo.AutoRent_Fuel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FuelType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AutoRent_Transmission",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TransmissionType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AutoRent_Type",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CarType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AutoRent_Contract",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        CarID = c.Int(nullable: false),
                        ContractPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeliveryAddressID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AutoRent_Car", t => t.CarID, cascadeDelete: true)
                .ForeignKey("dbo.AutoRent_DeliveryAddress", t => t.DeliveryAddressID)
                .ForeignKey("dbo.AutoRent_User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CarID)
                .Index(t => t.DeliveryAddressID);
            
            CreateTable(
                "dbo.AutoRent_DeliveryAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        Building = c.String(),
                        Discription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AutoRent_User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Lastname = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                        DriverLicenseNumber = c.String(),
                        RoleID = c.Int(),
                        PassportID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AutoRent_Passport", t => t.PassportID)
                .ForeignKey("dbo.AutoRent_Role", t => t.RoleID)
                .Index(t => t.RoleID)
                .Index(t => t.PassportID);
            
            CreateTable(
                "dbo.AutoRent_Passport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Series = c.String(),
                        Number = c.String(),
                        IssuePlace = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AutoRent_Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AutoRent_Contract", "UserID", "dbo.AutoRent_User");
            DropForeignKey("dbo.AutoRent_User", "RoleID", "dbo.AutoRent_Role");
            DropForeignKey("dbo.AutoRent_User", "PassportID", "dbo.AutoRent_Passport");
            DropForeignKey("dbo.AutoRent_Contract", "DeliveryAddressID", "dbo.AutoRent_DeliveryAddress");
            DropForeignKey("dbo.AutoRent_Contract", "CarID", "dbo.AutoRent_Car");
            DropForeignKey("dbo.AutoRent_Car", "TypeID", "dbo.AutoRent_Type");
            DropForeignKey("dbo.AutoRent_Car", "TransmissionID", "dbo.AutoRent_Transmission");
            DropForeignKey("dbo.AutoRent_Car", "FuelID", "dbo.AutoRent_Fuel");
            DropIndex("dbo.AutoRent_User", new[] { "PassportID" });
            DropIndex("dbo.AutoRent_User", new[] { "RoleID" });
            DropIndex("dbo.AutoRent_Contract", new[] { "DeliveryAddressID" });
            DropIndex("dbo.AutoRent_Contract", new[] { "CarID" });
            DropIndex("dbo.AutoRent_Contract", new[] { "UserID" });
            DropIndex("dbo.AutoRent_Car", new[] { "TransmissionID" });
            DropIndex("dbo.AutoRent_Car", new[] { "FuelID" });
            DropIndex("dbo.AutoRent_Car", new[] { "TypeID" });
            DropTable("dbo.AutoRent_Role");
            DropTable("dbo.AutoRent_Passport");
            DropTable("dbo.AutoRent_User");
            DropTable("dbo.AutoRent_DeliveryAddress");
            DropTable("dbo.AutoRent_Contract");
            DropTable("dbo.AutoRent_Type");
            DropTable("dbo.AutoRent_Transmission");
            DropTable("dbo.AutoRent_Fuel");
            DropTable("dbo.AutoRent_Car");
        }
    }
}
