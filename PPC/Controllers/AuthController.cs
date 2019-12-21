using PPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPC.Controllers
{
    public class AuthController : Controller
    {
        PPCDBEntities model = new PPCDBEntities();
        //
        // GET: /Admin/Auth/
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                var account = model.Accounts.Where(a => a.Username.Equals(acc.Username) && a.Password.Equals(acc.Password)).FirstOrDefault();
                if (account != null)
                {
                    Session["ID"] = account.ID;
                    Session["Username"] = account.Username.ToString();
                    Session["Role"] = account.Role.ToString();

                    return Redirect("/Admin/PropertyAdmin");
                }
            }
            return View(acc);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session["ID"] = null;
            Session["Username"] = null;
            Session["Role"] = null;

            return RedirectToAction("Login");
        }
    }
}