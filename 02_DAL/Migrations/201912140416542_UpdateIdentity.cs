namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "VipExp", c => c.DateTime());
            DropColumn("dbo.AspNetRoles", "Enable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Enable", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "VipExp");
        }
    }
}
