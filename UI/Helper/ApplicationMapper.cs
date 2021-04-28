using AutoMapper;
using Entity;
using System.Collections.Generic;
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
            CreateMap<CategoryModel, Category>().ReverseMap();
        } 
        #endregion
    }
}
