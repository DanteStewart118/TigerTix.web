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


      
        public IActionResult Index(Event ev)
            {
            _eventRepository.SaveEvent(ev);
            _eventRepository.SaveAll();

            return View();
            }

        public IActionResult Eventlist()
        {
            var results = from u in _eventRepository.GetAllEvents()
                          select u;
            return View(results.ToList());
        }
    
        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        private readonly IEventRepository _eventRepository;
    }
}
