using ProyectoPasantiaOIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPasantiaOIS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(UserModel user)
        {

            if (user.ussernameRegister == null || user.PasswordRegister == null)
            {
                return View("Login");
            }
            else
            {
                return View("Libreria");
            }

        }

    }

}