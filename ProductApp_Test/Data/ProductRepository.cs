using ProductApp_Test.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProductApp_Test.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        internal readonly object Products;

        public ProductRepository()
        {
            _context = new ProductContext();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);

            _context.SaveChangesAsync();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(o => o.Id == id);
        }

        public void Map(Product orginal, Product newproduct)
        {
            orginal.Name = newproduct.Name;
            orginal.Decription = newproduct.Decription;
            orginal.Price = newproduct.Price;
            orginal.Catagory = newproduct.Catagory;

        }
        public async Task<bool> SaveChangesAsync()
        {
            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}