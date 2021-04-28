using Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ApplicationDbContext :IdentityDbContext<User,Role,int>
    {
        #region Constructors
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions db) : base(db)
        {

        }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=TBLSYS081\SQLEXPRESS;Initial Catalog=ClickNBuy;Persist Security Info=True;User ID=sa;Password=tech123");
                //optionsBuilder.UseSqlServer(@"Data Source=RITESHPC\SQLEXPRESS;Initial Catalog=ClickNBuy;Persist Security Info=True;User ID=sa;Password=software123");
            }
            base.OnConfiguring(optionsBuilder);
        }
        #endregion

        #region Properties

        public DbSet<Category> Categories { get; set; }

        #endregion

    }
}
