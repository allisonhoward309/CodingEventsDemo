using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Data 
{
    public class EventCategoryDbContext : DbContext
    {
        public DbSet<EventCategory> EventCategory { get; set; }
        public EventCategoryDbContext(DbContextOptions<EventCategoryDbContext> options) : base(options)
        {
        }
    }
}
