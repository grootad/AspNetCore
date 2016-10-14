using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreWebPageNet.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAspNetCoreWebPageNet.Controllers
{
  public class AdressController : Controller
  {
    // GET: /<controller>/
    public IActionResult Index()
    {
      return View(Adress.List()); 
    }

    public IActionResult Single()
    {
      return View(Adress.Single());
    }


  }
}
