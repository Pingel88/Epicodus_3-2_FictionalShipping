using Microsoft.AspNetCore.Mvc;
using FictionalShipping.Models;
using System.Collections.Generic;

namespace FictionalShipping.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int height, int width, int length, int weight)
    {
      Parcel newParcel = new Parcel(height, width, length, weight);
      return RedirectToAction("Index");
    }
  }
}