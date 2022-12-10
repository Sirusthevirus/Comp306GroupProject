using Microsoft.AspNetCore.Mvc;

namespace Comp306GroupProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
