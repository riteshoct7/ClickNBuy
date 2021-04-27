using Microsoft.AspNetCore.Identity;

namespace Entity
{
    public class Role :IdentityRole<int>
    {
        #region Properties
        public string Description { get; set; } 
        #endregion
    }
}
