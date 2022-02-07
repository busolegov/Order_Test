using Order_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.DataService
{
    public class ClientService
    {
        private ApplicationDbContext _dbContext;
        public ClientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Client> GetClient(string text) 
        {
            IEnumerable<Client> result = _dbContext.Clients.Where(
                x=> x.FirstName.ToLower().Contains(text.ToLower()) || 
                    x.LastName.ToLower().Contains(text.ToLower())).ToList();
            return result;
        }
    }
}
