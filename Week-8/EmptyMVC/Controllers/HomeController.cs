using Microsoft.AspNetCore.Mvc;

namespace EmptyMVC.Controllers
{
	public class HomeController : Controller
	{
		// GET: HomeController
		public ActionResult Index()
		{
			return View();
		}

	}
}
