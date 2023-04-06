namespace MVC_Day5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropTable("dbo.Orders");
        }
    }
}
