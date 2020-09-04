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
            List<OrderViewModel> orders  = new List<OrderViewModel>();
               
                foreach (var order in context.Orders.ToList())
                {

                OrderViewModel orderVM = new OrderViewModel();

                    orderVM.Id = order.Id;
                    orderVM.Name = order.User.FirstName;
                    orderVM.Start = order.Start;
                    orderVM.End = order.End;
                    orderVM.Comment = order.Comment;

                    foreach (var car in order.Cars) 
                    {
                        orderVM.Mark = car.Mark;
                        orderVM.Model = car.Model;
                        orderVM.Price = car.Price ;
                    }

                orders.Add(orderVM);
                }     
           
            
            return View(orders);
        }
    }
}
