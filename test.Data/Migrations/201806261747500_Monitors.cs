namespace test.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monitors : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pupils", "IdClass", "dbo.SchoolClasses");
            AddColumn("dbo.Pupils", "SchoolClass_Id", c => c.Long());
            AddColumn("dbo.Pupils", "Monitor_Id", c => c.Long());
            AddColumn("dbo.SchoolClasses", "Monitor_Id", c => c.Long());
            CreateIndex("dbo.Pupils", "SchoolClass_Id");
            CreateIndex("dbo.Pupils", "Monitor_Id");
            CreateIndex("dbo.SchoolClasses", "Monitor_Id");
            AddForeignKey("dbo.SchoolClasses", "Monitor_Id", "dbo.Pupils", "Id");
            AddForeignKey("dbo.Pupils", "Monitor_Id", "dbo.SchoolClasses", "Id");
            AddForeignKey("dbo.Pupils", "SchoolClass_Id", "dbo.SchoolClasses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pupils", "SchoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.Pupils", "Monitor_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.SchoolClasses", "Monitor_Id", "dbo.Pupils");
            DropIndex("dbo.SchoolClasses", new[] { "Monitor_Id" });
            DropIndex("dbo.Pupils", new[] { "Monitor_Id" });
            DropIndex("dbo.Pupils", new[] { "SchoolClass_Id" });
            DropColumn("dbo.SchoolClasses", "Monitor_Id");
            DropColumn("dbo.Pupils", "Monitor_Id");
            DropColumn("dbo.Pupils", "SchoolClass_Id");
            AddForeignKey("dbo.Pupils", "IdClass", "dbo.SchoolClasses", "Id");
        }
    }
}
