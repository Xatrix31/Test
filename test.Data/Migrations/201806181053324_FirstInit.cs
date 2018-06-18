namespace test.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pupils",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        IdClass = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.IdClass)
                .Index(t => t.IdClass);
            
            CreateTable(
                "dbo.SchoolClasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClassName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherSchoolClasses",
                c => new
                    {
                        Teacher_Id = c.Long(nullable: false),
                        SchoolClass_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.SchoolClass_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_Id)
                .Index(t => t.Teacher_Id)
                .Index(t => t.SchoolClass_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pupils", "IdClass", "dbo.SchoolClasses");
            DropForeignKey("dbo.TeacherSchoolClasses", "SchoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.TeacherSchoolClasses", "Teacher_Id", "dbo.Teachers");
            DropIndex("dbo.TeacherSchoolClasses", new[] { "SchoolClass_Id" });
            DropIndex("dbo.TeacherSchoolClasses", new[] { "Teacher_Id" });
            DropIndex("dbo.Pupils", new[] { "IdClass" });
            DropTable("dbo.TeacherSchoolClasses");
            DropTable("dbo.Teachers");
            DropTable("dbo.SchoolClasses");
            DropTable("dbo.Pupils");
        }
    }
}
