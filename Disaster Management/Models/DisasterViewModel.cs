using Disaster_Management.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Disaster_Management.Models
{
    public class Disaster :IDisasterViewModel
    {
        public DisasterViewModel Model { get; set; }
        public readonly ApplicationDbContext _context;
        public Disaster(ApplicationDbContext context)
        {

            Model = new DisasterViewModel();
            _context = context;
        }


        public IEnumerable<DisasterViewModel> getAllDisasters()
        {
           return _context.Disasters.Select(x => new DisasterViewModel
           {
               category = x.category,
               date_occoured = x.date_occoured,
               location = x.location,
               severity = x.severity
           }); 
        }
    }

    public class DisasterViewModel
    {
        public Guid id { get; set; }
        public string? severity { get; set; }

        public string category { get; set; }

        public string? location { get; set; } 

        public DateTime date_occoured { get; set; }

    }
}
