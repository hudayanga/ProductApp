using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductsController : ApiController
    {
        IList<Product> products = new List<Product>()
        {
            new Product{ Id=1,Name="Milk",Category="C1",Price=34},
            new Product{ Id=2,Name="Tea",Category="C2",Price=22},
            new Product{ Id=3,Name="Soap",Category="C3",Price=12}
        };

        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var product= products.FirstOrDefault(p => p.Id == id);

            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}