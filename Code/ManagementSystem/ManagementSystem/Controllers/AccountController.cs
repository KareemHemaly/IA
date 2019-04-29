using ManagementSystem.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagementSystem.Controllers
{
    public class AccountController : Controller
    {

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(DAL.Entity.Users model)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(DAL.Entity.Users model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}