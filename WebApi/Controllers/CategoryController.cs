using AutoMapper;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper )
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public ActionResult<Category> GetAllCategories ()
        {
            IEnumerable<Category> lstCategory = categoryRepository.GetAll();
            return Ok(lstCategory);
        }
    }
}
