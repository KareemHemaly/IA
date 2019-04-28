namespace ManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        price = c.String(),
                        Created_By = c.String(),
                        Start_Date = c.String(),
                        End_Date = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsAssigned = c.Boolean(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectStatus",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IsActive = c.Boolean(nullable: false),
                        IsAssigned = c.Boolean(nullable: false),
                        Project_Id = c.String(),
                        Projects_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Projects_Id)
                .Index(t => t.Projects_Id);
            
            CreateTable(
                "dbo.Request_Type",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Created_By = c.String(),
                        Project_id = c.String(),
                        Sent_To = c.String(),
                        Approved = c.Boolean(nullable: false),
                        Request_Type_Id = c.String(),
                        Request_Type_Idest_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request_Type", t => t.Request_Type_Idest_Id)
                .Index(t => t.Request_Type_Idest_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IsActive = c.Boolean(nullable: false),
                        Project_Id = c.String(),
                        Member_Id = c.String(),
                        Project_Id1 = c.String(maxLength: 128),
                        User_Id_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id1)
                .ForeignKey("dbo.Users", t => t.User_Id_Id)
                .Index(t => t.Project_Id1)
                .Index(t => t.User_Id_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FName = c.String(),
                        LName = c.String(),
                        Mobile = c.String(),
                        JDescription = c.String(),
                        Photo = c.String(),
                        Email = c.String(),
                        User_Type = c.String(),
                        Users_type_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Users_type_Id)
                .Index(t => t.Users_type_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "User_Id_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Users_type_Id", "dbo.Roles");
            DropForeignKey("dbo.Teams", "Project_Id1", "dbo.Projects");
            DropForeignKey("dbo.Requests", "Request_Type_Idest_Id", "dbo.Request_Type");
            DropForeignKey("dbo.ProjectStatus", "Projects_Id", "dbo.Projects");
            DropIndex("dbo.Users", new[] { "Users_type_Id" });
            DropIndex("dbo.Teams", new[] { "User_Id_Id" });
            DropIndex("dbo.Teams", new[] { "Project_Id1" });
            DropIndex("dbo.Requests", new[] { "Request_Type_Idest_Id" });
            DropIndex("dbo.ProjectStatus", new[] { "Projects_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Teams");
            DropTable("dbo.Roles");
            DropTable("dbo.Requests");
            DropTable("dbo.Request_Type");
            DropTable("dbo.ProjectStatus");
            DropTable("dbo.Projects");
        }
    }
}
