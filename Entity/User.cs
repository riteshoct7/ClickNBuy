using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class User : IdentityUser<int>
    {
        #region Properties

        public string Name { get; set; }

        [NotMapped]
        public string[] Roles { get; set; } 

        #endregion
    }
}
