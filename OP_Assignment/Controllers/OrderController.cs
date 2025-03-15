using OP_Assignment.Models;
using OP_Assignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OP_Assignment.Controllers
{
    public class OrderController : Controller
    {
        private readonly DiscountService _discountService = new DiscountService();

        public ActionResult Index()
        {
            return View(new Order());
        }
        public ActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(Order order)
        {
            order.Discount = _discountService.CalculateDiscount(order.OrderAmount, order.CustomerType);
            return View("Result", order);
        }
    }
}