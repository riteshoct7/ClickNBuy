using Entity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAuthenticateService
    {

        #region Methods

        User Login(string userName, string password);

        Task<bool>   SignUp(User user, string password);

        User GetUser(string userName);

        Task<bool> SignOut();

        Task<SignInResult> Login1(string userName, string password);

        #endregion
    }
}
