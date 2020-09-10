using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;
using CarRental.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CarRental.Controllers
{
    public class OrderController : Controller
    {
        private readonly CarContext context;
        private readonly UserManager<User> userManager;
        public OrderController(CarContext carContext, UserManager<User> _userManager)
        {
            context = carContext;
            userManager = _userManager;
        }

        public IActionResult Index()
        {
            List<OrderViewModel> orders = new List<OrderViewModel>();

            foreach (var order in context.Orders.ToList())
            {

                OrderViewModel orderVM = new OrderViewModel();

                orderVM.Id = order.Id;
                orderVM.Name = context.Users.FirstOrDefault(x => x.Id == order.UserId).LastName;
                orderVM.Start = order.Start;
                orderVM.End = order.End;
                orderVM.Comment = order.Comment;
                
                foreach (var car in order.Cars)
                {
                    orderVM.Mark = car.Mark;
                    orderVM.Model = car.Model;
                    orderVM.Price = car.Price;
                }

                orders.Add(orderVM);
            }


            return View(orders);
        }
        [HttpGet]
        public IActionResult Create(int? id)
        {
            CreateOrderViewModel viewModel = new CreateOrderViewModel();
            if (id != null)
            {
                Car car = context.Cars.FirstOrDefault(p => p.Id == id);

                if (car != null)
                {
                    viewModel.Cars = car;

                }
               
            }
            else
            {
                viewModel.Cars = null;
            }
            return View(viewModel);
        }
        [HttpPost]
        [Authorize]
        public async Task <IActionResult >Create(CreateOrderViewModel orderViewModel,int? id )
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            var userId = claim.Value;

            //var current_User = await userManager.GetUserAsync(User);
            if (id != null)
            {
                Car car = context.Cars.FirstOrDefault(p => p.Id == id);
              
               

                Order order = new Order
                {
                    Start = orderViewModel.Start,
                    End = orderViewModel.End,
                    Comment = orderViewModel.Comment,
                    User = context.Users.FirstOrDefault(x => x.Id == userId)
                };
                if (car != null)
                {
                    order.Cars.Add(car);
                }


                await context.Orders.AddAsync(order);
                await context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
