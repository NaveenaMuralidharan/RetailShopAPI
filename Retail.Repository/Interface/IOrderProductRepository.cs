using Retail.Repositories.EntityModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Retail.Repositories.Interface
{
    public interface IOrderProductRepository
    {
        Task<IEnumerable<Order>> GetOrderDetails();
        Task<Order> GetOrderDetail(Guid id);
        Task<Order> PlaceOrder(Order Order);
        //Task UpdateOrderDetail(OrderProduct Order);
        Task DeleteOrder(Order Order);
    }
}

