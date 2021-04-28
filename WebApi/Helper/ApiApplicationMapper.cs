using AutoMapper;
using Entity;
using WebApi.Models;

namespace WebApi.Helper
{
    public class ApiApplicationMapper : Profile
    
    {
        #region Constructors
        public ApiApplicationMapper()
        {            
            CreateMap<CategoryModel, Category>().ReverseMap();
        }
        #endregion
    }
}
