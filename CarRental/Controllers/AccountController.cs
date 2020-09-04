using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models.ViewModels;
using CarRental.Models;
using Microsoft.AspNetCore.Identity;



namespace CarRental.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public AccountController( UserManager<User> user, SignInManager<User> signIn)
        {
     

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
