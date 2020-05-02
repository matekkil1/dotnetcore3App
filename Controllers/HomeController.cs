using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalManager.Data;
using PersonalManager.Models;
using PersonalManager.Services;
using PersonalManager.ViewModels;

namespace PersonalManager.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IMailService _mailService;
        private readonly IManagerRepository Repository;

        public HomeController( IMailService mailService, IManagerRepository repository)
        {
           
            _mailService = mailService;
            Repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("mymail@.com", "subject", "middle");
                ViewBag.Message = "Sent";
            }
            else
            {
                //show some error
            }
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
