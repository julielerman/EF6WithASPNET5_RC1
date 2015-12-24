using EF6Model;
using Microsoft.AspNet.Mvc;

namespace WebApplication1.Controllers
{
  public class NinjaController : Controller
  {
    INinjaRepository _repo;

    public NinjaController(INinjaRepository repo) {
      _repo = repo;
    }
    public IActionResult Index() {
      return View(_repo.GetAllNinjas());
    }

  }
}

