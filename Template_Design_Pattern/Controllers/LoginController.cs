using Microsoft.AspNetCore.Mvc;

namespace Template_Design_Pattern.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
