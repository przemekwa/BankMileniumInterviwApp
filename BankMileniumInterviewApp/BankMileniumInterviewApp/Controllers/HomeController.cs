using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using BankMileniumInterviewApp.Models;

namespace BankMileniumInterviewApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (HttpContext.Session["currentCuture"] == null)
            {
                HttpContext.Session["currentCuture"] = "PL";
            }

            var model = new UserInfo
            {
                CurrentCuture = HttpContext.Session["currentCuture"].ToString()
            };
           
            return View(model);
        }

        [HttpPost]
        public ActionResult Next(UserInfo userInfo)
        {
            userInfo.CurrentCuture = HttpContext.Session["currentCuture"].ToString();

            this.ModelState.Clear();

            if (!Regex.IsMatch(userInfo.Name, "[A-Za-z]{2}")) 
            {
                this.ModelState.AddModelError("name", "Pole nazwa użytkonikwa musi mieć tylko litery o maksymalnej długości 30 znaków.");
            }

            if (!Regex.IsMatch(userInfo.Email, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                this.ModelState.AddModelError("Email", "Pole email nie zawira poprawnego adresu email");
            }

            if (!this.ModelState.IsValid)
            {
                return View("Index", userInfo);
            }

            return View(userInfo);
        }

        public ActionResult Set(string userCuture)
        {
            HttpContext.Session["currentCuture"] = userCuture;

            return RedirectToAction("Index");
        }
    }
}