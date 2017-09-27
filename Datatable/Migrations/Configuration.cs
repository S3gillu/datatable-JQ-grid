namespace Datatable.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Datatable.Models.WorkerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Datatable.Models.WorkerContext context)
        {

            context.Offices.AddOrUpdate(
               p => p.OfficePlace,
               new Office { OfficePlace = "Washington" },
               new Office { OfficePlace = "Kansas City" }
               );
           
        }
    }
}
