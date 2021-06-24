using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpeedApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedApp.Controllers
{
    public class HomeController : Controller
    {        
       
        public IActionResult Index()
        {
            SpeedApp.ViewModel.SpeedViewModel model = new ViewModel.SpeedViewModel();
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(SpeedApp.ViewModel.SpeedViewModel model)
        {
            if (ModelState.IsValid)
            {
                Random rand = new Random();
                model.Speed = rand.Next(200);
                SpeedService svc = new SpeedService();
                model.FineCode = svc.checkforFines(model.Speed, model.IsBirthday);
            }
            return View(model);
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
