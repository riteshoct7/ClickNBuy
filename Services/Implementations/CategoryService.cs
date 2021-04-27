using Entity;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class CategoryService : ICategoryService
    {

        #region Properties

        private readonly ICategoryRepository categoryRepository;

        #endregion

        #region Constructors
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        #endregion

        #region Methods
        public void Delete(int Categoryid)
        {
            categoryRepository.Delete(Categoryid);
            categoryRepository.SaveChanges();
        }

        public IEnumerable<Category> GetAllCatefgories()
        {
            return categoryRepository.GetAll();
        }

        public Category GetByCategoryId(int Categoryid)
        {
            return categoryRepository.GetById(Categoryid);
        }

        public Category GetCategoryByDescription(string description)
        {
            return categoryRepository.GetCategoryByDescription(description);
        }

        public Category GetCategoryByName(string categoryName)
        {
            return categoryRepository.GetCategoryByName(categoryName);
        }

        public void RemoveCategory(Category catgeory)
        {
            categoryRepository.Remove(catgeory);
            categoryRepository.SaveChanges();
        }

        public void SaveCategory(Category catgeory)
        {
            categoryRepository.Add(catgeory);
            categoryRepository.SaveChanges();
        }

        public void UpdateCategory(Category catgeory)
        {
            categoryRepository.Update(catgeory);
            categoryRepository.SaveChanges();
        } 
        #endregion

    }
}
