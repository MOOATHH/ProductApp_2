using ProductApp_Test.Data;
using ProductApp_Test.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProductApp_Test.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        ProductRepository _repository;

        public ProductsController()
        {
            _repository = new ProductRepository();
        }

        public IHttpActionResult Get(Product product)
        {
            var products = _repository.GetProducts();
            return Ok(products);
        }


        public void Post(Product product)
        {
            _repository.AddProduct(product);
        }

        // PUT api/<controller>/5
        public async Task<IHttpActionResult> Put(int id, Product product)
        {
            try
            {
                var J = _repository.GetProduct(id);

                _repository.Map(J, product);

                await _repository.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // DELETE api/<controller>/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var product = _repository.GetProduct(id);

                _repository.DeleteProduct(product);

                await _repository.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
