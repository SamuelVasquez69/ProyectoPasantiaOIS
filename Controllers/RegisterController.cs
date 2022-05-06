using ProyectoPasantiaOIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasantiaOIS.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View("Register");
        }

        public ActionResult Register(UserModel user)
        {

            if (user.ussernameRegister == null || user.PasswordRegister == null)
            {
                return View("Register");
            }
            else
            {
                return View("Login");
                /* return "todo bien" + user.PasswordRegister + " " + user.ussernameRegister;*/
            }

        }

    }
}