using Common.Repository;
using ManagementSystem.BLL.Service;
using ManagementSystem.DAL.Context;
using ManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        UserService UserService;
        public AccountController()
        {
            UserService = new UserService(new Repository<SystemContext,Users>());
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Account/Register
        [HttpPost]
        public ActionResult Register(Users users)
        {
          bool x=  UserService.Add(users);
            if(x==true)
            return Json(users, JsonRequestBehavior.AllowGet);
            else
                return Json(null, JsonRequestBehavior.AllowGet);


        }




        public ActionResult Login(Users users)
        {
            var username = users.Email;
            var password = users.Password;
            TempData["name"] = username;
            Users user = UserService.get(username, password);
            if (user != null)
            {

                return Json(users, JsonRequestBehavior.AllowGet);

            }

            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        //
        // POST: /Account/Login
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(DAL.Entity.Users model)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}