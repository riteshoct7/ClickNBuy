using AutoMapper;
using Common;
using Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Resources;
using Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;


namespace UI.Controllers
{
    public class AccountController : Controller
    {

        #region Properties

        private readonly IAppResource _sharedLocalizer;
        private readonly IMapper mapper;
        private readonly IAuthenticateService authService;

        #endregion

        #region Constructors
        public AccountController(IAppResource sharedLocalizer, IMapper mapper, IAuthenticateService authService)
        {
            _sharedLocalizer = sharedLocalizer;
            this.mapper = mapper;
            this.authService = authService;
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
        public IActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = authService.Login(model.UserName, model.Password);
                if (user != null)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    if (user.Roles.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else if (user.Roles.Contains("User"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "User" });
                    }
                }
            }
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(model);
                user.UserName = model.Email;
                user.CreatedDate = Util.GetCurrentDateTime();                
                bool result = await authService.SignUp(user, model.Password);
                if (result)
                {
                    return RedirectToAction("Login");
                }                
            }
            return View(model);
        }
        
        #endregion

    }
}
