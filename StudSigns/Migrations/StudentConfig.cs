namespace StudSigns.Migrations.StudentMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class StudentConfig : DbMigrationsConfiguration<StudSigns.StudentContext>
    {
        public StudentConfig()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudSigns.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
