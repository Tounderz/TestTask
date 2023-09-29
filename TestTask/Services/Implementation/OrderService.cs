using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrder()
        {
            var order = await _context.Orders
             .OrderByDescending(o => o.Price)
            .FirstOrDefaultAsync();

            return order;
        }

        public async Task<List<Order>> GetOrders()
        {
            var orders = await _context.Orders.Where(i => i.Quantity > 10).ToListAsync();
            if (orders == null || orders.Count < 1)
            {
                return null;
            }

            return orders;
        }
    }
}
