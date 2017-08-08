using Microsoft.AspNetCore.Mvc;
using CoinCombinations.Models;
using System.Collections.Generic;
using System;

namespace CoinCombinations.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/MakeItRain")]
    public ActionResult MakeItRain()
    {
      CashMoney newCash = new CashMoney(int.Parse(Request.Form["cash"]));
      return View(newCash.CheckDatMoney());
    }
  }
}
