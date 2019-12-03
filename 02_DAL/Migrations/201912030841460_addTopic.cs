namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTopic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Content = c.String(),
                        IsEnable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Lessons", "Grama", c => c.String());
            AddColumn("dbo.AspNetUsers", "IsVip", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsVip");
            DropColumn("dbo.Lessons", "Grama");
            DropTable("dbo.Topics");
        }
    }
}
