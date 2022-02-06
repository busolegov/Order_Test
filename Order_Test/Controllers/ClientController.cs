using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            IEnumerable<Client> clients = _dbContext.Clients;
            //var clients = _dbContext.Clients.Where(x => x.FirstName.Contains(text))
            //.Select(x => x.FirstName).ToList();
            return View(clients);
        }

        public IActionResult FindClient(string text)
        {
            var client = _dbContext.Clients.Where(x => x.FirstName.Contains(text))
                .Select(x => x.FirstName).ToList();
            return View(client);
        }
    }
}
