using Entity;

namespace Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        #region Methods

        Category GetCategoryByName(string categoryName);
        Category GetCategoryByDescription(string description); 

        #endregion
    }
}
