using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Areas.Admin.ViewModels;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinmanager;

        public AccountController(UserManager<AppUser> usermeneger,SignInManager<AppUser> signInManager)
        {
               _userManager= usermeneger;
            _signinmanager= signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel adminLoginViewModel)
        {
            AppUser appUser = await _userManager.FindByNameAsync(adminLoginViewModel.UserName);
            var result = await _signinmanager.PasswordSignInAsync(appUser, adminLoginViewModel.Password,false,false);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
