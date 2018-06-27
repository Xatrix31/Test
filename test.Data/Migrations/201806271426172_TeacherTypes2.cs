namespace test.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherTypes2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Teachers", "IdType");
            AddForeignKey("dbo.Teachers", "IdType", "NSI.TeacherTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "IdType", "NSI.TeacherTypes");
            DropIndex("dbo.Teachers", new[] { "IdType" });
        }
    }
}
