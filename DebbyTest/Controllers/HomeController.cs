using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DebbyTest.Models;
using DebbyTest.DATA;
using DebbyTest.Services;

namespace DebbyTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerService _customerService;
        
        public HomeController(CustomerService customerService)
        {
            _customerService = customerService;
        }


        public IActionResult Index()
        {
            var customer = _customerService.GetOneCustomer();
            return View(customer);
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
    }
}
