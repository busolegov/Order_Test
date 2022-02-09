using Microsoft.EntityFrameworkCore;
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

        public async Task SaveNewOrder(Order order, int id)
        {
            if (order.Type == "Cash")
            {
                order.Period = null;
            }
            _dbContext.Add(new Order 
            {
                ClientId = id,
                TotalPrice = order.TotalPrice,
                Type = order.Type,
                Period = order.Period
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
