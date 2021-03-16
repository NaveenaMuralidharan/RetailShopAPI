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

        public void Update(Guid productId, ProductViewModel entity)
        {
            var productToUpdate = getById(productId);
            
            if (productToUpdate == null)
            {
                throw new Exception("The Product record couldn't be found.");
            }

            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.AvailableQuantity = entity.AvailableQuantity;

            _productRepository.Update(productToUpdate);
        }
        public void Delete(Product product)
        {
             _productRepository.Delete(product);
        }



    }
}

