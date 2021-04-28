using Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System.Collections.Generic;
using UI.Areas.Admin.Models;

namespace UI.Areas.Admin.Controllers
{    
    public class CategoryController : BaseController
    {
        #region Properties
        private readonly ICategoryRepository categoryRepository;
        #endregion

        #region Construcors
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        #endregion

        #region Methods
        public IActionResult List()
        {
            CategoryModel obj = new CategoryModel();
            obj.CategoryId = 1;
            obj.CategoryName = "Shirts";
            obj.Description = "Shirt";

            List<CategoryModel> lst = new List<CategoryModel>();
            lst.Add(obj);

            IEnumerable<Category> lstCategory = categoryRepository.GetAll();

            return View(lst);
        } 
        #endregion
    }
}
