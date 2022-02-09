using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Order_Test.DataService;
using Order_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ClientController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string text)
        {
            ClientService service = new ClientService(_dbContext);
            var result = service.GetClient(text);
            TempData["search"] = JsonConvert.SerializeObject(result);
            return RedirectToAction("SearchResult");
        }


        [HttpGet]
        public IActionResult SearchResult()
        {
            var item = TempData["search"];
            var list = JsonConvert.DeserializeObject<IEnumerable<Client>>((string)(item));
            return View(list);
        }
    }
}
