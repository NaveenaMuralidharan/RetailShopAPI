using Retail.Repositories.EntityModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Retail.Models.ViewModels;


namespace Retail.Services.Interface
{
    public interface IOrderProductService
    {

        Task<IEnumerable<Order>> GetOrderDetails();
        Task<Order> GetOrderDetail(Guid id);
        Task<Order> PlaceOrder(OrderViewModel Order);
        //Task UpdateOrderDetail(Guid id,OrderProductViewModel Order);
        Task DeleteOrder(Guid id);
    }
}
