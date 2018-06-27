namespace test.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherTypes1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "NSI.TeacherTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teachers", "IdType", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "IdType");
            DropTable("NSI.TeacherTypes");
        }
    }
}
