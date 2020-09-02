using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        CarContext context;
        public CarController(CarContext carContext)
        {
            context = carContext;
        }
        public IActionResult Index()
        {
            return View(context.Cars.ToList());
        }
    }
}
