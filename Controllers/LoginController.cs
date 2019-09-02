using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayRollV1.Models;

namespace PayRollV1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login(Login object1)
        {
            string query1 = " select (case when exists (select * from login where username = '" + object1.UserName + "' and password='" + object1.Password + "') then 1 else 0 end) as flag";
            int reader = SqlDBOperation.Query1(query1);
            if (reader == 1)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View("Login");
            }

        }
    }
}