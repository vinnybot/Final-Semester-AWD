using Microsoft.AspNetCore.Mvc;
using TripLog2.Models.DataAccess;
using TripLog2.Models.DomainModels;

namespace TripLog2.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Trip> tripData { get; set; }

        public HomeController(TripLog2Context ctx)
        {
            tripData = new Repository<Trip>(ctx);
        }


        public IActionResult Index()
        {
            var options = new QueryOptions<Trip>
            {
                Includes = "Destination, Accomodation, Activities",
                OrderBy = t => t.StartDate!
            };

            var trips = tripData.List(options);
            return View(trips);
        }


    }
}