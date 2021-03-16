using Microsoft.EntityFrameworkCore;
using Retail.Repositories.EntityModels;
using Retail.Repositories.Interface;
using Retail.Repository;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Retail.Repositories.Implementations
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Order>> GetOrderDetails()
        {
            var result = await _appDbContext.OrderProducts.Include(x => x.Product).ToListAsync();
            return result;
        }
        public async Task<Order> GetOrderDetail(Guid id)
        {
            return await _appDbContext.OrderProducts.FindAsync(id);

        }
        public async Task<Order> PlaceOrder(Order Order)
        {
            var result = _appDbContext.OrderProducts.Add(Order);
            await _appDbContext.SaveChangesAsync();
            return Order;
        }

        public async Task DeleteOrder(Order Order)
        {
            _appDbContext.OrderProducts.Remove(Order);
            await _appDbContext.SaveChangesAsync();
        }

    }
}
