using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class SignUpModel
    {

        #region Properties 

        [Required(ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "FirstNameRequiredMessage")]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "LastNameRequiredMessage")]
        
        public string LastName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "EmailRequiredMessage")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "InValidEmail")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "PasswordRequiredMessage")]
        [StringLength(100, ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "PasswordLengthMessage", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "PasswordConfirmationMatch")]
        public string ConfirmPassword { get; set; }

        public bool SubscribedForPromotions { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.AccountResource), ErrorMessageResourceName = "AcceptedTermsConditionRequiredMessage")]
        public bool AcceptedTermsCondition { get; set; } 

        #endregion

    }
}
