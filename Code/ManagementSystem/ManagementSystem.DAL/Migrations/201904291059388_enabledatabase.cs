namespace ManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enabledatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectStatus", "Has_TM", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProjectStatus", "Has_PM", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.ProjectStatus", "IsActive");
            DropColumn("dbo.ProjectStatus", "IsAssigned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectStatus", "IsAssigned", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProjectStatus", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.ProjectStatus", "Has_PM");
            DropColumn("dbo.ProjectStatus", "Has_TM");
        }
    }
}
