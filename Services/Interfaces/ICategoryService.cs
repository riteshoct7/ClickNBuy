using Entity;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        public void SaveCategory(Category catgeory);

        public void Delete(int Categoryid);

        public IEnumerable<Category> GetAllCatefgories ();

        public Category GetByCategoryId(int Categoryid);

        public void RemoveCategory(Category catgeory);

        public void UpdateCategory(Category catgeory);

        Category GetCategoryByName(string categoryName);
        Category GetCategoryByDescription(string description);

    }
}
