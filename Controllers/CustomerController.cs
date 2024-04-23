using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() { Id = 1, Name = "Shane" , Amount = 12000},
            new Customer() { Id = 2, Name = "Rashini", Amount = 14000}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.Customers = customers;

            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        // Attribute Routing (Default Page) :- [Route("~/")]
        [Route("~/sample/message")]
        public IActionResult Message()
        {
            ViewData["Message"] = "Welcome to Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["Customers"] = customers;

            return View();
        }
    }
}
