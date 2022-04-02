using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerTix.web.Data;
using TigerTix.web.Data.Entities;
using TigerTix.web.ViewModels;
namespace TigerTix.web.Controllers
{
    public class EventsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult EventSubmission()
        {
            return View();
        }


    }
}
