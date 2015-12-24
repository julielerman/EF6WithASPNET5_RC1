namespace EF6Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NinjaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NinjaContext context)
        {
             context.Ninjas.AddOrUpdate(
              p => p.Name,
              new Ninja { Name = "Julie Lerman" },
              new Ninja { Name = "Brice Lambson" },
              new Ninja { Name = "Rowan Miller" }
            );

        }
    }
}
