using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
//using WebApplication5.Helpers;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class BannerController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public BannerController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            List<Posts> posts = _applicationDbContext.Posts.ToList();
            return View(posts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Posts posts)
        {
            //string path = "C:\\Users\\ca.r214.18\\source\\repos\\WebApplication5\\WebApplication5\\wwwroot\\uploads\\banner\\";
            //posts.Images= FileMeneger.SaveFile(path,"uploads/banner",posts.ImagesFile);
            _applicationDbContext.Posts.Add(posts);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            _applicationDbContext.Posts.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Update(Posts posts)
        {
            Posts Expost = _applicationDbContext.Posts.Find(posts.Id);
            Expost.Header = posts.Header;
            Expost.RedirectUrl = posts.RedirectUrl;
            Expost.Title = posts.Title;
            Expost.BannerHeader = posts.BannerHeader;
            Expost.ButtonRedirectUrl= posts.ButtonRedirectUrl;
            Expost.ButtonredirectText= posts.ButtonredirectText;
            Expost.Description= posts.Description;
            _applicationDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Posts posts = _applicationDbContext.Posts.Find(id);
            _applicationDbContext.Remove(posts);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
