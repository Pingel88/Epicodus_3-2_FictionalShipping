using Microsoft.AspNetCore.Mvc;

namespace FictionalShipping.Controllers
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