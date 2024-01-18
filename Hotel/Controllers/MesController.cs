using Hotel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Controllers
{

    public class MesController : Controller
    {
        private readonly UserContext _context;

        public MesController(UserContext context)
        {
            _context = context;
        }
  

        public async Task<IActionResult> AllMes()
        {
            var mes = await _context.Messages.Include(m=>m.user).ToListAsync();
            return View(mes);

        }
       

        // GET: MesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Messages mes, string UserName)
        {
            if (ModelState.IsValid)
            {
      
                var user = _context.Users.Where(e => e.Login == UserName).FirstOrDefault();
                if (user != null)
                //{
                //    return View(mes);
                //}
                mes.user = user;
                mes.Datetime= DateTime.Now;
                _context.Messages.Add(mes);
                _context.SaveChanges();
             
                return RedirectToAction("AllMes", "Mes");
            }
                return View(mes);
            }
         


    }
}
