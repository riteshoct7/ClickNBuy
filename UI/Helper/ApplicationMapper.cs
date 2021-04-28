using AutoMapper;
using Entity;
using UI.Areas.Admin.Models;
using UI.Models;

namespace UI.Helper
{
    public class ApplicationMapper :Profile 
    {
        #region Constructors
        public ApplicationMapper()
        {
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<SignUpModel, User>().ReverseMap();
            CreateMap<LoginModel, User>().ReverseMap();
        } 
        #endregion
    }
}
