using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Controllers
{
    public class OrderController : Controller
    {
        CarContext context;
        public OrderController(CarContext carContext)
        {
            context = carContext;
        }

        public IActionResult Index()
        {
            var order = new OrderViewModel();
           //order.Id = context.Orders.Find(Id);
            
            return View(context.Orders.ToList());
        }
    }
}
