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
            CreateMap<SignUpModel, User>().ReverseMap();
            CreateMap<LoginModel, User>().ReverseMap();
        } 
        #endregion
    }
}
