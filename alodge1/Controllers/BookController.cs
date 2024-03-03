using Microsoft.AspNetCore.Mvc;

namespace alodge1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
