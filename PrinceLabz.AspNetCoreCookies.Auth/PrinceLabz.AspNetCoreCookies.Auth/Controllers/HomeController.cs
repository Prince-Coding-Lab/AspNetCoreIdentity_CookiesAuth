using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrinceLabz.AspNetCoreCookies.Auth.Models;

namespace PrinceLabz.AspNetCoreCookies.Auth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Product> _lst { get; set; }
      
        public HomeController(ILogger<HomeController> logger)
        {
            List<Product> lst = new List<Product>();
            lst.Add(new Product() { Title = "title 1", Description = "des1" });
            lst.Add(new Product() { Title = "title 2", Description = "des2 " });
            _lst = lst;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [Authorize]
        public async Task<IActionResult> Product()
        {
       
            return View(_lst);
        }
    }
}
