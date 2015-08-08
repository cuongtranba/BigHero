namespace BigHero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_UserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "UserId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Items", "UserId", "dbo.UserProfile", "UserId", cascadeDelete: true);
            CreateIndex("dbo.Items", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Items", new[] { "UserId" });
            DropForeignKey("dbo.Items", "UserId", "dbo.UserProfile");
            DropColumn("dbo.Items", "UserId");
        }
    }
}
