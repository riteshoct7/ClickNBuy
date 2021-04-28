using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewComponents
{
    public class LanguageDropdDownViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;


        #region Constructors

        public LanguageDropdDownViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        #endregion

        #region Methods

        public IViewComponentResult Invoke()
        {
            var items = categoryService.GetAllCatefgories();
            return View("~/Views/Shared/_LanguageDropdDownViewComponent.cshtml", items);
        }

        #endregion
    }
}
