using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Data.Abstract;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private StoreAppContext context = new StoreAppContext();

        public IEnumerable<Product> Products()
        {
            return context.Products;
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            if (product.Id == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product productToUpdate = context.Products.Find(product.Id);
                if (productToUpdate != null)
                {
                    productToUpdate.Name = product.Name;
                    productToUpdate.Price = product.Price;
                    productToUpdate.Description = product.Description;
                    productToUpdate.CategoryId = product.CategoryId;
                }
            }

            return await context.SaveChangesAsync();
        }

        public async Task<Product> DeleteProductAsync(int id)
        {
            Product findProduct = context.Products.Find(id);

            if (findProduct != null)
            {
                context.Products.Remove(findProduct);
            }

            await context.SaveChangesAsync();
            return findProduct;
        }
    }
}
