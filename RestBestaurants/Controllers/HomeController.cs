using Microsoft.AspNetCore.Mvc;

namespace RestBestaurants.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
