using System.Collections.Generic;
using System.Threading.Tasks;
using StoreApp.Data.Abstract;
using StoreApp.Entities.Concrete;

namespace StoreApp.Data.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        StoreAppContext context = new StoreAppContext();

        public IEnumerable<Category> Categories()
        {
            return context.Categories;
        }

        public async Task<int> SaveCategoryAsync(Category category)
        {
            if (category.Id == 0)
            {
                context.Categories.Add(category);
            }
            else
            {
                Category categoryToUpdate = context.Categories.Find(category.Id);
                if (categoryToUpdate != null)
                {
                    categoryToUpdate.Name = category.Name;
                }
            }

            return await context.SaveChangesAsync();
        }

        public async Task<Category> DeleteCategoryAsync(int id)
        {
            Category findCategory = context.Categories.Find(id);

            if (findCategory != null)
            {
                context.Categories.Remove(findCategory);
            }

            await context.SaveChangesAsync();
            return findCategory;
        }
    }
}
