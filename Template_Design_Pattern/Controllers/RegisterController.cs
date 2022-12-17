using Microsoft.AspNetCore.Mvc;

namespace Template_Design_Pattern.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
