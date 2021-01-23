using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            TempData["name"] = "Ekle";
            data.Services.kLoginServices services = new data.Services.kLoginServices();
            return View(services.GetAllList());
            
        }


        public IActionResult Edit(int? Id)
        {
            var result = new data.Models.KLogin();
            if (Id.HasValue && Id>0)
            {
                data.Services.kLoginServices services  = new data.Services.kLoginServices();
                result = services.GetById(Id.Value);

            }
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(data.Models.KLogin dt)
        {
            data.Services.kLoginServices services = new data.Services.kLoginServices();
            var result = services.Save(dt);
            if (result>0)
            {
                return RedirectToAction("Index", "Home");
                ViewBag.userContext = "Hoş Geldiniz";

            }
            return RedirectToAction("Index","User");
        }
        
        public IActionResult Delete(int Id)
        {
            data.Services.kLoginServices usersrv = new data.Services.kLoginServices();
            usersrv.Delete(Id);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            ViewBag.userContext = "Hoş Geldiniz";
            return View();
        }
    }
}
