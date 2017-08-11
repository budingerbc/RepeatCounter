using Microsoft.AspNetCore.Mvc;
using RepeatCounterApp.Models;
using System;

namespace RepeatCounterApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/result")]
    public ActionResult Result()
    {
      RepeatCounter myCounter = new RepeatCounter();
      myCounter.CountRepeats(Request.Form["word-input"], Request.Form["sentence-input"]);

      return View(myCounter);
    }
  }
}
