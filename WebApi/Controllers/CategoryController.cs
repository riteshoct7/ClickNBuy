using AutoMapper;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        #region Properties

        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper; 

        #endregion

        #region Constructors
        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        #endregion

        #region Methods

        [HttpGet]
        public IEnumerable<Category> GetAllCtaegories()
        {
            return categoryRepository.GetAll().ToList();
        }

        #endregion

    }
}
