using System;
using System.Collections.Generic;
using System.Text;
using Retail.Repository.EntityModels;
using Retail.ViewModels;

namespace Retail.Services.Interface
{
    public interface IProductService
    {
        List<Product> Get();

        void Add(ProductViewModel orderViewModel);

        public Product getById(Guid productid);
        public void Update(Guid id, ProductViewModel entity);
        public void Delete(Product product);



    }
}

