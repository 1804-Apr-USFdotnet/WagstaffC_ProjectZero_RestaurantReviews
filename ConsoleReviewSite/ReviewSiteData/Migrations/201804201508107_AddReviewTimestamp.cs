namespace ReviewSiteData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReviewTimestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "DatePublished", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "DatePublished");
        }
    }
}
