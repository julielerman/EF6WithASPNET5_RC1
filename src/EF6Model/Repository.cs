using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Model
{
  public interface INinjaRepository
  {
    List<Ninja> GetAllNinjas();
  }
  public class NinjaRepository : INinjaRepository
  {
    NinjaContext _context;
    //  NinjaContext _context;
    public NinjaRepository(NinjaContext context) {
      _context = context;
    }
    public List<Ninja> GetAllNinjas() {
      return _context.Ninjas.ToList();
    }
  }
}
