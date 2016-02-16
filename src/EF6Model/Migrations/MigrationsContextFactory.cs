using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Model.Migrations
{
  public class MigrationsContextFactory : IDbContextFactory<NinjaContext>
  {
    public NinjaContext Create() {
      return new NinjaContext("Server = (localdb)\\mssqllocaldb; Database = NinjaContext; Trusted_Connection = True; MultipleActiveResultSets = true");
    }
  }
}
