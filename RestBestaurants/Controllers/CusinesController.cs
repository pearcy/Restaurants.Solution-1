using Microsoft.AspNetCore.Mvc;
using RestBestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RestBestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly RestBestaurantsContext _db;

    public RestBestaurantsControllers(RestBestaurantsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Cuisine> model = _db.Description.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
  }
}