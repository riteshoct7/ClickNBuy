using AutoMapper;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using UI.Areas.Admin.Models;

namespace UI.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        #region Properties
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        #endregion

        #region Construcors
        public CategoryController(ICategoryRepository categoryRepository, IMapper  mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        #endregion

        #region Methods
        public IActionResult List()
        {                
            return View(categoryRepository.GetAll());
        } 

        public IActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                Category objCategory = mapper.Map<Category>(model);
                categoryRepository.Add(objCategory);
                categoryRepository.SaveChanges();
                return RedirectToAction("List");
            }
            return View(model);
        }


        public IActionResult Edit (int id)
        {
            Category objCategory = categoryRepository.GetById(id);
            if (objCategory !=null)
            {
                CategoryModel categoryModel = mapper.Map<CategoryModel>(objCategory);
                return View(categoryModel);
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                Category objCategory = mapper.Map<Category>(model);
                categoryRepository.Update(objCategory);
                categoryRepository.SaveChanges();
                return RedirectToAction("List");
            }
            return View(model);
        }

        #endregion
    }
}
