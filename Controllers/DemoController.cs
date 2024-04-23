using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            TempData["Message"] = "Welcome to Customer Management System";
            return View();
        }

        public IActionResult Details()
        {
            if (TempData["Message"] == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Alert"] = "Success";
                return View();
            }
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "Shane");
            return RedirectToAction("SuccessLogin");
        }

        public IActionResult SuccessLogin()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }

        public IActionResult QueryTest()
        {
            string name = "Shane Kanishka";
            
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"])) 
            {
                name = HttpContext.Request.Query["name"];    
            }
            ViewBag.Name = name;

            return View();
        }
    }
}
