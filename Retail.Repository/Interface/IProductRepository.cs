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
        public Product getById(Guid productid);
        public void Update(Product product, Product entity);
        public void Delete(Product product);
    }
}
