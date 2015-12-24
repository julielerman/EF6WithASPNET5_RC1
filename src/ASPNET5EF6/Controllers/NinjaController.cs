using EF6Model;
using Microsoft.AspNet.Mvc;

namespace WebApplication1.Controllers
{
    public class NinjaController : Controller
    {
         public IActionResult Index()
        {
            var repo = new Repository();

                return View(repo.GetAllNinjas());
            }
           
        }
    }

