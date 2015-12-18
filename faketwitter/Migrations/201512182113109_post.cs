namespace faketwitter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class post : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "PostedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostedDate", c => c.DateTime(nullable: false));
        }
    }
}
