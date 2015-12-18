namespace faketwitter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followers",
                c => new
                    {
                        FollowerId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FollowerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Follower_FollowerId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Followers", t => t.Follower_FollowerId)
                .Index(t => t.Follower_FollowerId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        PostedDate = c.DateTime(nullable: false),
                        user_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Users", t => t.user_UserId)
                .Index(t => t.user_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Follower_FollowerId", "dbo.Followers");
            DropForeignKey("dbo.Posts", "user_UserId", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "user_UserId" });
            DropIndex("dbo.Users", new[] { "Follower_FollowerId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Users");
            DropTable("dbo.Followers");
        }
    }
}
