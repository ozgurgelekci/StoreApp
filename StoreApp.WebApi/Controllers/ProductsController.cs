using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete.EntityFramework;
using StoreApp.Entities.Concrete;

namespace StoreApp.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductRepository _productRepository;

        public ProductsController()
        {
            //Örnek oldugundan Dependency Injection ile uğraşmadım.
            _productRepository = new EfProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.Products();
        }

        public IEnumerable<Product> GetApprovedProducts()
        {
            return _productRepository.Products().Where(i => i.IsApproved);
        }

        public Product GetProduct(int id)
        {
            var product = _productRepository.Products().FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                return product;
            }
        }

        public async Task<IHttpActionResult> PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.SaveProductAsync(product);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }
    }
}
