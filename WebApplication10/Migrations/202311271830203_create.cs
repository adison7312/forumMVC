namespace WebApplication10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        FilePath = c.String(),
                        FileSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BannedLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                        AddedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ForumCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        ThreadsNumber = c.Int(nullable: false),
                        PostsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModeratorAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ForumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ThreadID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Content = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrivateMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderID = c.Int(nullable: false),
                        ReceiverID = c.Int(nullable: false),
                        Content = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        IsMessageRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MinPostsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Threads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ForumID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Title = c.String(),
                        Pinned = c.Boolean(nullable: false),
                        ViewsNumber = c.Int(nullable: false),
                        AnswersNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ProfilePicture = c.String(),
                        LastTimeActive = c.DateTime(nullable: false),
                        RoleID = c.Int(nullable: false),
                        Status = c.String(),
                        Language = c.String(),
                        Skin = c.String(),
                        Settings = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Threads");
            DropTable("dbo.Roles");
            DropTable("dbo.Ranks");
            DropTable("dbo.PrivateMessages");
            DropTable("dbo.Posts");
            DropTable("dbo.ModeratorAssignments");
            DropTable("dbo.Forums");
            DropTable("dbo.ForumCategories");
            DropTable("dbo.BannedLists");
            DropTable("dbo.Attachments");
        }
    }
}
