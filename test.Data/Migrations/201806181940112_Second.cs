namespace test.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pupils", "Gender", c => c.String(nullable: false));
            DropColumn("dbo.Pupils", "Sex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pupils", "Sex", c => c.String(nullable: false));
            DropColumn("dbo.Pupils", "Gender");
        }
    }
}
