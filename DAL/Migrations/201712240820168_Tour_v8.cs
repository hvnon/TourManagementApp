namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tour_v8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CityID = c.Int(nullable: false),
                        Code = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.CustomerGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.CustomerID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        IdentityNumber = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        TourID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PickupLocation = c.String(nullable: false),
                        DropLocation = c.String(nullable: false),
                        Description = c.String(),
                        Policy = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tours", t => t.TourID)
                .Index(t => t.TourID);
            
            CreateTable(
                "dbo.GroupFees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        FeeTypeID = c.Int(nullable: false),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FeeTypes", t => t.FeeTypeID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.GroupID)
                .Index(t => t.FeeTypeID);
            
            CreateTable(
                "dbo.FeeTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        TourTypeID = c.Int(nullable: false),
                        FromCity = c.Int(nullable: false),
                        FromDistrict = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Night = c.Int(nullable: false),
                        Status = c.String(),
                        Price = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.FromCity)
                .ForeignKey("dbo.Districts", t => t.FromDistrict)
                .ForeignKey("dbo.TourTypes", t => t.TourTypeID)
                .Index(t => t.TourTypeID)
                .Index(t => t.FromCity)
                .Index(t => t.FromDistrict);
            
            CreateTable(
                "dbo.TourLocations",
                c => new
                    {
                        TourID = c.Int(nullable: false),
                        LocationID = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TourID, t.LocationID })
                .ForeignKey("dbo.Locations", t => t.LocationID)
                .ForeignKey("dbo.Tours", t => t.TourID)
                .Index(t => t.TourID)
                .Index(t => t.LocationID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CityID = c.Int(nullable: false),
                        DistrictID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID)
                .ForeignKey("dbo.Districts", t => t.DistrictID)
                .Index(t => t.CityID)
                .Index(t => t.DistrictID);
            
            CreateTable(
                "dbo.TourTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        IdentityNumber = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GroupHistories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.EmployeeID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.TourPriceHistories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TourID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tours", t => t.TourID)
                .Index(t => t.TourID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TourPriceHistories", "TourID", "dbo.Tours");
            DropForeignKey("dbo.Roles", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.Roles", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.GroupHistories", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.CustomerGroups", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.Groups", "TourID", "dbo.Tours");
            DropForeignKey("dbo.Tours", "TourTypeID", "dbo.TourTypes");
            DropForeignKey("dbo.TourLocations", "TourID", "dbo.Tours");
            DropForeignKey("dbo.TourLocations", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.Locations", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Locations", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Tours", "FromDistrict", "dbo.Districts");
            DropForeignKey("dbo.Tours", "FromCity", "dbo.Cities");
            DropForeignKey("dbo.GroupFees", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.GroupFees", "FeeTypeID", "dbo.FeeTypes");
            DropForeignKey("dbo.CustomerGroups", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Districts", "CityID", "dbo.Cities");
            DropIndex("dbo.TourPriceHistories", new[] { "TourID" });
            DropIndex("dbo.Roles", new[] { "GroupID" });
            DropIndex("dbo.Roles", new[] { "EmployeeID" });
            DropIndex("dbo.GroupHistories", new[] { "GroupID" });
            DropIndex("dbo.Locations", new[] { "DistrictID" });
            DropIndex("dbo.Locations", new[] { "CityID" });
            DropIndex("dbo.TourLocations", new[] { "LocationID" });
            DropIndex("dbo.TourLocations", new[] { "TourID" });
            DropIndex("dbo.Tours", new[] { "FromDistrict" });
            DropIndex("dbo.Tours", new[] { "FromCity" });
            DropIndex("dbo.Tours", new[] { "TourTypeID" });
            DropIndex("dbo.GroupFees", new[] { "FeeTypeID" });
            DropIndex("dbo.GroupFees", new[] { "GroupID" });
            DropIndex("dbo.Groups", new[] { "TourID" });
            DropIndex("dbo.CustomerGroups", new[] { "GroupID" });
            DropIndex("dbo.CustomerGroups", new[] { "CustomerID" });
            DropIndex("dbo.Districts", new[] { "CityID" });
            DropTable("dbo.TourPriceHistories");
            DropTable("dbo.Roles");
            DropTable("dbo.GroupHistories");
            DropTable("dbo.Employees");
            DropTable("dbo.TourTypes");
            DropTable("dbo.Locations");
            DropTable("dbo.TourLocations");
            DropTable("dbo.Tours");
            DropTable("dbo.FeeTypes");
            DropTable("dbo.GroupFees");
            DropTable("dbo.Groups");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerGroups");
            DropTable("dbo.Districts");
            DropTable("dbo.Cities");
        }
    }
}
