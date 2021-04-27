using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Areas.Admin.Models;

namespace UI.Areas.Admin.Controllers
{    
    public class CategoryController : BaseController
    {
        public CategoryController()
        {

        }

        public IActionResult List()
        {
            CategoryModel obj = new CategoryModel();
            obj.CategoryId = 1;
            obj.CategoryName = "Shirts";
            obj.Description = "Shirt";

            List<CategoryModel> lst = new List<CategoryModel>();
            lst.Add(obj);

            return View(lst);
        }
    }
}
