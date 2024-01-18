using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
        public class HomeController : Controller
        {
        
            private readonly UserContext _context;

            public HomeController(UserContext context)
            {
                _context = context;
            }
            public ActionResult Index()
        {
            return View();
        
        }
            public ActionResult Logout()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Account");
            }
        }
    }