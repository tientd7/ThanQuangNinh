namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editTopicsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "Vocalbularies", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Topics", "Vocalbularies");
        }
    }
}
