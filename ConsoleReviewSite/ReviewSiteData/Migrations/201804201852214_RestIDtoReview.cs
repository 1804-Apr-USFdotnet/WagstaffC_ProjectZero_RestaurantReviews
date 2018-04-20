namespace ReviewSiteData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestIDtoReview : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "Restaurant_Id" });
            RenameColumn(table: "dbo.Reviews", name: "Restaurant_Id", newName: "RestaurantId");
            AlterColumn("dbo.Reviews", "RestaurantId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "RestaurantId");
            AddForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "RestaurantId" });
            AlterColumn("dbo.Reviews", "RestaurantId", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "RestaurantId", newName: "Restaurant_Id");
            CreateIndex("dbo.Reviews", "Restaurant_Id");
            AddForeignKey("dbo.Reviews", "Restaurant_Id", "dbo.Restaurants", "Id");
        }
    }
}
