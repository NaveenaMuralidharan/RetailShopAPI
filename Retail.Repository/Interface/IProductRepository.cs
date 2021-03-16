using Retail.Repository.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> Get();
        void Add(Product product);
        Product getById(Guid productid);
        void Update(Product entity);
        void Delete(Product product);
    }
}
