using Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System.Linq;

namespace Repository.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        #region Constructors
        public CategoryRepository(DbContext db) : base(db)
        {

        }

        #endregion

        #region Properties

        public ApplicationDbContext appDbContext
        {
            get
            {
                return db as ApplicationDbContext;
            }
        }

        #endregion

        #region Methods

        public Category GetCategoryByDescription(string description)
        {
            return appDbContext.Categories.Where(x => x.Description == description).FirstOrDefault();
        }

        public Category GetCategoryByName(string categoryName)
        {
            return appDbContext.Categories.Where(x => x.CategoryName == categoryName).FirstOrDefault();
        } 

        #endregion

    }
}
