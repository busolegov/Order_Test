using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Order_Test.DataService;
using Order_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Order_Test.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public OrderController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Order order, int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var orderService = new OrderService(_dbContext);
            await orderService.SaveNewOrder(order, id);
            return RedirectToAction("Index", "Client");
        }
    }

}
