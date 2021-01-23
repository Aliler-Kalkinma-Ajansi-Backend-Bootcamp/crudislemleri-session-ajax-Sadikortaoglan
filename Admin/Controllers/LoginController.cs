using data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login() => View();
        [HttpPost]
        public ActionResult Login(KLogin User)
        {
            data.Services.kLoginServices src = new data.Services.kLoginServices();

            var userid = src.Login(User.KullaniciAdi, User.Sifre);

            if (userid != 0 && userid > 0)
            {
                return RedirectToAction("Index", "Home");
                TempData["Name"] = User.KullaniciAdi;
            }
            return RedirectToAction("Login", "Giris");

        }
    }
}
