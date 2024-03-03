using Microsoft.AspNetCore.Mvc;

namespace alodge1.Controllers
{
	public class RoomController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
