using System;
using System.Collections.Generic;
using System.Linq;
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
            if (userInfo.Name != "ds")
            {
                this.ModelState.AddModelError("name", "żle");

            }

            userInfo.CurrentCuture = HttpContext.Session["currentCuture"].ToString();

            return View(userInfo);
        }

        public ActionResult Set(string userCuture)
        {
            HttpContext.Session["currentCuture"] = userCuture;

            return RedirectToAction("Index");
        }
    }
}