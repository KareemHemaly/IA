namespace ManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _int : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Requests", "Request_Type_Idest_Id", "dbo.Request_Type");
            DropForeignKey("dbo.Users", "Users_type_Id", "dbo.Roles");
            DropForeignKey("dbo.Teams", "User_Id_Id", "dbo.Users");
            DropIndex("dbo.Requests", new[] { "Request_Type_Idest_Id" });
            DropIndex("dbo.Teams", new[] { "User_Id_Id" });
            DropIndex("dbo.Users", new[] { "Users_type_Id" });
            DropPrimaryKey("dbo.ProjectStatus");
            DropPrimaryKey("dbo.Request_Type");
            DropPrimaryKey("dbo.Requests");
            DropPrimaryKey("dbo.Roles");
            DropPrimaryKey("dbo.Teams");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.ProjectStatus", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProjectStatus", "Project_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Request_Type", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Requests", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Requests", "Request_Type_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Requests", "Request_Type_Idest_Id", c => c.Int());
            AlterColumn("dbo.Roles", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Teams", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Teams", "Member_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Teams", "User_Id_Id", c => c.Int());
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Users", "User_Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Users_type_Id", c => c.Int());
            AddPrimaryKey("dbo.ProjectStatus", "Id");
            AddPrimaryKey("dbo.Request_Type", "Id");
            AddPrimaryKey("dbo.Requests", "Id");
            AddPrimaryKey("dbo.Roles", "Id");
            AddPrimaryKey("dbo.Teams", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            CreateIndex("dbo.Requests", "Request_Type_Idest_Id");
            CreateIndex("dbo.Teams", "User_Id_Id");
            CreateIndex("dbo.Users", "Users_type_Id");
            AddForeignKey("dbo.Requests", "Request_Type_Idest_Id", "dbo.Request_Type", "Id");
            AddForeignKey("dbo.Users", "Users_type_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Teams", "User_Id_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "User_Id_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Users_type_Id", "dbo.Roles");
            DropForeignKey("dbo.Requests", "Request_Type_Idest_Id", "dbo.Request_Type");
            DropIndex("dbo.Users", new[] { "Users_type_Id" });
            DropIndex("dbo.Teams", new[] { "User_Id_Id" });
            DropIndex("dbo.Requests", new[] { "Request_Type_Idest_Id" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Teams");
            DropPrimaryKey("dbo.Roles");
            DropPrimaryKey("dbo.Requests");
            DropPrimaryKey("dbo.Request_Type");
            DropPrimaryKey("dbo.ProjectStatus");
            AlterColumn("dbo.Users", "Users_type_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Users", "User_Type", c => c.String());
            AlterColumn("dbo.Users", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Teams", "User_Id_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Teams", "Member_Id", c => c.String());
            AlterColumn("dbo.Teams", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Roles", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Requests", "Request_Type_Idest_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Requests", "Request_Type_Id", c => c.String());
            AlterColumn("dbo.Requests", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Request_Type", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProjectStatus", "Project_Id", c => c.String());
            AlterColumn("dbo.ProjectStatus", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Teams", "Id");
            AddPrimaryKey("dbo.Roles", "Id");
            AddPrimaryKey("dbo.Requests", "Id");
            AddPrimaryKey("dbo.Request_Type", "Id");
            AddPrimaryKey("dbo.ProjectStatus", "Id");
            CreateIndex("dbo.Users", "Users_type_Id");
            CreateIndex("dbo.Teams", "User_Id_Id");
            CreateIndex("dbo.Requests", "Request_Type_Idest_Id");
            AddForeignKey("dbo.Teams", "User_Id_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "Users_type_Id", "dbo.Roles", "Id");
            AddForeignKey("dbo.Requests", "Request_Type_Idest_Id", "dbo.Request_Type", "Id");
        }
    }
}
