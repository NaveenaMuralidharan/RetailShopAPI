using Retail.Services.Interface;
using Retail.Repository.Interface;
using System.Collections.Generic;
using Retail.Repository.EntityModels;
using Retail.ViewModels;
using System;

namespace Retail.Services.Implementation
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public object Repository { get; private set; }

        public ProductService(IProductRepository orderRepository)
        {
            _productRepository = orderRepository;
        }


        public List<Product> Get()
        {
            return _productRepository.Get();
        }

        public void Add(ProductViewModel productViewModel)
        {

            var product = new Product()
            {
                ProductName = productViewModel.ProductName,
                ProductId = productViewModel.ProductId,
                AvailableQuantity = productViewModel.AvailableQuantity
            };

            _productRepository.Add(product);


        }
        public Product getById(Guid productid)
        {
            return _productRepository.getById(productid);
        }

        public void Update(Product product, ProductViewModel entity)
        {
            var Update = new Product()
            {
                ProductName = entity.ProductName,
                ProductId = entity.ProductId,
                AvailableQuantity = entity.AvailableQuantity
            };

            _productRepository.Update(product, Update);
        }
        public void Delete(Product product)
        {
             _productRepository.Delete(product);
        }



    }
}

