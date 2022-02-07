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
            var item = TempData["client"];
            var client = JsonConvert.DeserializeObject<IEnumerable<Client>>((string)(item));

            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal price)
        {

            _dbContext.Add(new Order 
            {
                TotalPrice = price,

            });
            return View();
        }
    }

}
