using Microsoft.AspNetCore.Mvc;
using Chapter_8.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter_8.Controllers
{
    public class TripController : Controller
    {
        private TripContext context { get; set; }

        public TripController(TripContext ctx) => context = ctx;

        public ViewResult Add(string id = "")
        {
            var vm = new TripViewModel();

            if (id.ToLower() == "page2")
            {
                vm.PageNumber = 2;
                vm.Trip.Accommodation = TempData.Peek(nameof(Trip.Accommodation))?.ToString()!;
                return View("Add2", vm);
            } 
            else if (id.ToLower() == "page3")
            {
                vm.PageNumber = 3;
                vm.Trip.Destination = TempData.Peek(nameof(Trip.Destination))?.ToString()!;
                return View("Add3", vm);
            }
            else
            {
                vm.PageNumber = 1;
                return View("Add1", vm);
            }
        }

        [HttpPost]
        public IActionResult Add(TripViewModel vm)
        {
            if (vm.PageNumber == 1)
            {
                if (ModelState.IsValid)
                {
                    TempData[nameof(Trip.Destination)] = vm.Trip.Destination;
                    TempData[nameof(Trip.Accommodation)] = vm.Trip.Accommodation;
                    TempData[nameof(Trip.StartDate)] = vm.Trip.StartDate;
                    TempData[nameof(Trip.EndDate)] = vm.Trip.EndDate;
                    return RedirectToAction("Add", new { id = "Page2" });
                }
                else
                {
                    return View("Add1", vm);
                }
            }
            else if (vm.PageNumber == 2)
            {
                TempData[nameof(Trip.AccommodationPhone)] = vm.Trip.AccommodationPhone;
                TempData[nameof(Trip.AccommodationEmail)] = vm.Trip.AccommodationEmail;
                return RedirectToAction("Add", new { id = "Page3" });
            }

            else if (vm.PageNumber == 3)
            {
                vm.Trip.Destination = TempData[nameof(Trip.Destination)]?.ToString()!;
                vm.Trip.Accommodation = TempData[nameof(Trip.Accommodation)]?.ToString()!;
                vm.Trip.StartDate = (DateTime)TempData[nameof(Trip.StartDate)]!;
                vm.Trip.EndDate = (DateTime)TempData[nameof(Trip.EndDate)]!;
                vm.Trip.AccommodationPhone = TempData[nameof(Trip.AccommodationPhone)]?.ToString()!;
                vm.Trip.AccommodationEmail = TempData[nameof(Trip.AccommodationEmail)]?.ToString()!;

                context.Trips.Add(vm.Trip);
                context.SaveChanges();
                TempData["message"] = $"Trip to {vm.Trip.Destination} added.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
