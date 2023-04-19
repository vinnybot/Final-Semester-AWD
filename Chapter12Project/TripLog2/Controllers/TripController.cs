using Microsoft.AspNetCore.Mvc;
using TripLog2.Models.DataAccess;
using TripLog2.Models.DomainModels;
using TripLog2.Models.ViewModels;

namespace TripLog2.Controllers
{
    public class TripController : Controller
    {
        private Repository<Trip> TripData { get; set; }
        private Repository<Destination> DestinationData { get; set; }
        private Repository<Accomodation> AccomodationData { get; set; }
        private Repository<Activity> ActivityData { get; set; }

        public TripController(TripLog2Context ctx)
        {
            TripData = new Repository<Trip>(ctx);
            DestinationData = new Repository<Destination>(ctx);
            AccomodationData = new Repository<Accomodation>(ctx);
            ActivityData = new Repository<Activity>(ctx);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add(string id = "")
        {
            var vm = new TripViewModel();

            if (id.ToLower() == "page1")
            {
                vm.PageNumber = 1;

                //get data for drop-downs
                vm.Destinations = DestinationData.List(new QueryOptions<Destination>
                {
                    OrderBy = d => d.Name
                });

                vm.Accomodations = AccomodationData.List(new QueryOptions<Accomodation>
                {
                    OrderBy = a => a.Name
                });

                return View("Add1", vm);
            } else if (id.ToLower() == "page2")
            {
                vm.PageNumber = 2;

                int destID = (int)TempData.Peek("DestinationId")!;
                vm.Trip.Destination = DestinationData.Get(destID)!;

                //Get data for the select list
                vm.Activities = ActivityData.List(new QueryOptions<Activity>
                {
                    OrderBy = d => d.Name
                });

                return View("Add2", vm);
            } else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Add (TripViewModel vm)
        {
            if (vm.PageNumber == 1)
            {
                if (ModelState.IsValid)
                {
                    TempData["DestinationId"] = vm.Trip.DestinationId;
                    TempData["AccomodationId"] = vm.Trip.AccomodationId;
                    TempData["StartDate"] = vm.Trip.StartDate;
                    TempData["EndDate"] = vm.Trip.EndDate;
                    return RedirectToAction("Add", new { id = "page2" });
                }
                else
                {
                    // Invalid data validation
                    vm.Destinations = DestinationData.List(new QueryOptions<Destination>
                    {
                        OrderBy = d => d.Name
                    });

                    vm.Accomodations = AccomodationData.List(new QueryOptions<Accomodation>
                    {
                        OrderBy = a => a.Name
                    });
                    //re-display View
                    return View("Add1", vm);
                }
            } else if (vm.PageNumber == 2)
            {
                vm.Trip.DestinationId = (int)TempData["DestinationId"]!;
                vm.Trip.AccomodationId = (int)TempData["AccomodationId"]!;
                vm.Trip.StartDate = (DateTime)TempData["StartDate"]!;
                vm.Trip.EndDate = (DateTime)TempData["EndDate"]!;

                foreach (int id in vm.SelectedActivities)
                {
                    var activity = ActivityData.Get(id)!;
                    if (activity != null)
                    {
                        vm.Trip.Activities.Add(activity);
                    }
                }
                //add trip to database
                TripData.Insert(vm.Trip);
                TripData.Save();

                //get destination for notifiction message
                var dest = DestinationData.Get(vm.Trip.DestinationId);
                TempData["message"] = $"Trip to {dest?.Name} added.";

                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public RedirectToActionResult Delete (int id)
        {
            Trip trip = TripData.Get(new QueryOptions<Trip>
            {
                Includes = "Destination",
                Where = t => t.TripId == id

            })!;

            if (trip != null)
            {
                TripData.Delete(trip);
                TripData.Save();
            }
            TempData["message"] = $"Trip to {trip.Destination.Name} deleted!";

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
