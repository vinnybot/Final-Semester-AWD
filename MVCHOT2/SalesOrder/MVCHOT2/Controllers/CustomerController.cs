﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHOT2.Models.DomainModels;
using MVCHOT2.Models.DataLayer;

namespace MVCHOT2.Controllers
{
    public class CustomerController : Controller
    {
        private SalesOrderContext context { get; set; }

        public CustomerController(SalesOrderContext ctx) => context = ctx;

        [Route("[controller]s")]

        public IActionResult List()
        {
            var customers = context.Customers.OrderBy(x => x.CustomerFirstName).ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customers = context.Customers.Find(id);
            return View(customers);
        }

        [HttpPost]
        public IActionResult Edit(Customer modifiedCustomer)
        {
            if (ModelState.IsValid)
            {
                if (modifiedCustomer.CustomerID == 0)
                //adding a new customer
                {
                    context.Customers.Add(modifiedCustomer);
                }
                else
                {
                    //updating an existing product
                    context.Customers.Update(modifiedCustomer);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Customer");
            }
            else
            {
                //invalid data - didnt pass through validation
                ViewBag.Action = (modifiedCustomer.CustomerID == 0) ? "Add" : "Edit";
                return View(modifiedCustomer);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Customer = context.Customers.OrderBy(p => p.CustomerFirstName).ToList();
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("List", "Customer");
        }
    }
}
