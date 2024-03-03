using Microsoft.AspNetCore.Mvc;

namespace alodge1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
