namespace ManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProjectStatus", "Projects_Id", "dbo.Projects");
            DropForeignKey("dbo.Teams", "Project_Id1", "dbo.Projects");
            DropIndex("dbo.ProjectStatus", new[] { "Projects_Id" });
            DropIndex("dbo.Teams", new[] { "Project_Id1" });
            DropPrimaryKey("dbo.Projects");
            AlterColumn("dbo.Projects", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProjectStatus", "Projects_Id", c => c.Int());
            AlterColumn("dbo.Teams", "Project_Id1", c => c.Int());
            AddPrimaryKey("dbo.Projects", "Id");
            CreateIndex("dbo.ProjectStatus", "Projects_Id");
            CreateIndex("dbo.Teams", "Project_Id1");
            AddForeignKey("dbo.ProjectStatus", "Projects_Id", "dbo.Projects", "Id");
            AddForeignKey("dbo.Teams", "Project_Id1", "dbo.Projects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Project_Id1", "dbo.Projects");
            DropForeignKey("dbo.ProjectStatus", "Projects_Id", "dbo.Projects");
            DropIndex("dbo.Teams", new[] { "Project_Id1" });
            DropIndex("dbo.ProjectStatus", new[] { "Projects_Id" });
            DropPrimaryKey("dbo.Projects");
            AlterColumn("dbo.Teams", "Project_Id1", c => c.String(maxLength: 128));
            AlterColumn("dbo.ProjectStatus", "Projects_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Projects", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Projects", "Id");
            CreateIndex("dbo.Teams", "Project_Id1");
            CreateIndex("dbo.ProjectStatus", "Projects_Id");
            AddForeignKey("dbo.Teams", "Project_Id1", "dbo.Projects", "Id");
            AddForeignKey("dbo.ProjectStatus", "Projects_Id", "dbo.Projects", "Id");
        }
    }
}
