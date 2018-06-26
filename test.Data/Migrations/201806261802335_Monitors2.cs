namespace test.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monitors2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pupils", "Monitor_Id", "dbo.SchoolClasses");
            DropIndex("dbo.Pupils", new[] { "Monitor_Id" });
            DropColumn("dbo.Pupils", "Monitor_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pupils", "Monitor_Id", c => c.Long());
            CreateIndex("dbo.Pupils", "Monitor_Id");
            AddForeignKey("dbo.Pupils", "Monitor_Id", "dbo.SchoolClasses", "Id");
        }
    }
}
