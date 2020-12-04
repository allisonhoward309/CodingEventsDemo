using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventCategoryDbContext context;
        public EventCategoryController (EventCategoryDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<EventCategory> events = context.EventCategory.ToList();
            return View(events);
        }
    }
}
