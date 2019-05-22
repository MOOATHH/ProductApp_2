using ProductApp_Test.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ProductApp_Test.Data
{
    public interface IProductRepository
    {
        // General 
        Task<bool> SaveChangesAsync();

        // Products
        void AddProduct(Product product);
        void DeleteProduct(Product Product);
    }
}