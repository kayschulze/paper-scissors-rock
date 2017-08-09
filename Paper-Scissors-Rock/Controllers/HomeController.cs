using Microsoft.AspNetCore.Mvc;
using PaperScissorsRock.Models;
using System.Collections.Generic;
using System;

namespace PaperScissorsRock.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/results")]
    public ActionResult Results()
    {
      PSRClass game = new PSRClass(Request.Form["p1Option"], Request.Form["p2Option"]);
      //string result = game.DetermineWinner();
      return View(game);
    }

  }
}
