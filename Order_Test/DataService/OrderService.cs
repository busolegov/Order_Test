using Order_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Test.DataService
{
    public class OrderService
    {
        private ApplicationDbContext _dbContext;
        public OrderService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task GetNewOrder(Client client) 
        {
            _dbContext.Add(new Order 
            {
                ClientId = client.Id
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
