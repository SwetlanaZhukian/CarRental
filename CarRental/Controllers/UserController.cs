using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class UserController : Controller
    {
        CarContext context;
        public UserController(CarContext carContext) 
        {
            context = carContext;
        }
        public IActionResult Index()
        {
            return View(context.Users.ToList()); ;
        }
    }
}
