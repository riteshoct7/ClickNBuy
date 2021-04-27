using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAuthenticateService
    {

        #region Methods

        User Login(string userName, string password);

        bool SingUp(User user, string password);

        User GetUser(string userName);

        Task<bool> SignOut(); 

        #endregion
    }
}
