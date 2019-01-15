using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete.EntityFramework;
using StoreApp.Entities.Concrete;

namespace StoreApp.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        private ICategoryRepository _categoryRepository;

        public CategoriesController()
        {
            //Örnek oldugundan Dependency Injection ile uğraşmadım.
            _categoryRepository = new EfCategoryRepository();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.Categories();
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.Categories().FirstOrDefault(x => x.Id == id);
        }

        public async Task PostCategory(Category category)
        {
            await _categoryRepository.SaveCategoryAsync(category);
        }

        public async Task DeleteCategory(int id)
        {
            await _categoryRepository.DeleteCategoryAsync(id);
        }
    }
}
