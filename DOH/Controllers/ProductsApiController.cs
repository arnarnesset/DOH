using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Umbraco.Web.WebApi;
using DOH.Models;

namespace DOH.Controllers
{
    public class ProductsApiController : UmbracoApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 3.21m },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 4.49m },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 23.99m }
        };

        /// <summary>
        /// Accessed by calling <host>/umbraco/api/ProductsApi/GetAllProducts
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        /// <summary>
        /// Accessed by calling host/ProductsApi/GetProductById/[id]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            /*
             * Available resources in UmbracoApi
             * 
                var ac = ApplicationContext;
                var applicationCache = ac.ApplicationCache;
                var dbContext = ac.DatabaseContext;
                var isConfigured = ac.IsConfigured;

                var services = ac.Services;
                var s = ac.Services;
                var u = Umbraco;
                var uc = UmbracoContext;
            */

            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }
    }
}