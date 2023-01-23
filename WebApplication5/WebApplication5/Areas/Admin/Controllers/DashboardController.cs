using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userMeneger;
        public DashboardController(UserManager<AppUser> userManager)
        {
            _userMeneger = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser appUser = new AppUser
        //    {
        //        FullName = "Nurlan Mammadov",
        //        UserName = "Admin"
        //    };
        //  var result = await _userMeneger.CreateAsync(appUser, "Admin123");
        //    return Ok(result);
        //}
    }
}
