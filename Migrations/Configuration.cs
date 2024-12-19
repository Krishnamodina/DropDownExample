namespace DropDownExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DropDownExample.Models.AppicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DropDownExample.Models.AppicationDbContext context)
        {
            context.Departments.AddOrUpdate(
                d=> d.Name,
                new Models.Department { Name="HR"},
                new Models.Department { Name="IT"},
                new Models.Department { Name="Finance"}
                );
        }
    }
}
