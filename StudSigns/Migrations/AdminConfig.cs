namespace StudSigns.Migrations.AdminMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class AdminConfig : DbMigrationsConfiguration<StudSigns.AdministratorContext>
    {
        public AdminConfig()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudSigns.AdministratorContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
