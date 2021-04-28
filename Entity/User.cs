using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class User : IdentityUser<int>
    {
        #region Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool SubscribedForPromotions { get; set; }

        public bool AcceptedTermsCondition { get; set; }

        [NotMapped]
        public string[] Roles { get; set; } 

        #endregion
    }
}
