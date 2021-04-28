using Entity;
using Microsoft.AspNetCore.Identity;
using Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class AuthenticateService : IAuthenticateService
    {
        #region Properties

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<Role> roleManager; 

        #endregion

        #region Constructors

        public AuthenticateService(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        #endregion

        #region Methods

        public User GetUser(string userName)
        {
            return userManager.FindByNameAsync(userName).Result;
        }

        public User Login (string userName, string password)
        {
            var result = signInManager.PasswordSignInAsync(userName,password,false,false).Result;
            
            if (result.Succeeded)
            {
                var user = userManager.FindByNameAsync(userName).Result;
                var roles = userManager.GetRolesAsync(user).Result;
                user.Roles = roles.ToArray();
                return user;                  
            }
            return null;
        }

        public Task<SignInResult> Login1(string userName, string password)
        {
            return  signInManager.PasswordSignInAsync(userName, password, false, false);                        
        }

        public async Task<bool> SignOut()
        {
            try
            {
                await signInManager.SignOutAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SignUp(User user, string password)
        {
            var result = userManager.CreateAsync(user, password).Result;
            if (result.Succeeded)
            {                
                if (!roleManager.RoleExistsAsync(Common.Constants.UserRoleTitle).Result)
                {                    
                    Role objRole = new Role();
                    objRole.Name = Common.Constants.UserRoleTitle;
                    objRole.NormalizedName = Common.Constants.UserRoleTitle;
                    objRole.Description = Common.Constants.UserRoleTitle;
                    await roleManager.CreateAsync(objRole);
                }
                var roleResult = userManager.AddToRoleAsync(user, Common.Constants.UserRoleTitle).Result;
                if (roleResult.Succeeded)
                {
                    return true;
                }
            }
            return false;
        } 

        #endregion
    }
}
