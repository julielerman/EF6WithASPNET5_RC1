using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace EF6Model
{

 
  public class NinjaContext : DbContext
  {
    public NinjaContext(string connectionString) :
      base(connectionString) {
    }
    public DbSet<Ninja> Ninjas { get; set; }
  }
}