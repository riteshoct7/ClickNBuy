using Entity;

namespace Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        #region Methods

        Category GetcategoryByName(string categoryName);
        Category GetcategoryByDescription(string description); 

        #endregion
    }
}
