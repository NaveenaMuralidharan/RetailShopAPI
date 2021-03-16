using Retail.Repository.EntityModels;
using Retail.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Retail.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {

        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Product> Get()
        {
            return _dbContext.Products.ToList();
        }

       
       /// <summary>
       /// 
       /// </summary>
       /// <param name="product"></param>
        public void Add(Product product)
        {

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productid"></param>
        /// <returns></returns>
        public Product getById(Guid productid)
        {
            return _dbContext.Products
                  .FirstOrDefault(p => p.ProductId == productid);
        }
        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
        }
        public void Delete(Product product)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }
    }
}

