using System.Data.Entity.Migrations;
using test.Models.Entities;

namespace test.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.Model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.Model context)
        {
            //  This method will be called after migrating to the latest version.
            base.Seed(context);
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.TeacherTypes.AddOrUpdate(new TeacherType { Id = 1, Title = "Director" });
            context.TeacherTypes.AddOrUpdate(new TeacherType { Id = 2, Title = "Head Teacher" });
            context.TeacherTypes.AddOrUpdate(new TeacherType { Id = 3, Title = "Teacher" });
            context.SaveChanges();
        }
    }
}
