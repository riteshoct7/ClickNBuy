using Microsoft.AspNetCore.Mvc;
using Resources;
using UI.Models;

namespace UI.Controllers
{
    public class AccountController : Controller
    {

        #region Properties

        private readonly IAppResource _sharedLocalizer;

        #endregion

        #region Constructors
        public AccountController(IAppResource sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
        }
        #endregion

        #region Methods
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        } 
        #endregion

    }
}
