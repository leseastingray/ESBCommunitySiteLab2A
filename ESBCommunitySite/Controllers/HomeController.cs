using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ESBCommunitySite.Models;

namespace ESBCommunitySite.Controllers
{
    public class HomeController : Controller
    {
        // Index method
        public ViewResult Index()
        {
            return View();
        }
        // History method
        public ViewResult History()
        {
            return View();
        }
        // Contact get method
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        // Contact post method
        [HttpPost]
        public ViewResult Contact(ContactInfo contactInfo)
        {
            // stores contact messages
            MailBox.AddMail(contactInfo);
            return View();
        }

        public ViewResult ShowMail()
        {
            return View(MailBox.Mail);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
