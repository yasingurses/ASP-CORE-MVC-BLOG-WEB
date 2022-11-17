using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReaAkademiProje.Controllers
{
    public class GenelController : Controller
    {
        private readonly IBlogService bl;
        private readonly ITeamService tm;

        public GenelController(IBlogService bl,ITeamService tm)
        {
            this.bl = bl;
            this.tm = tm;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            var result = bl.Listing();
            return View(result);
        }
        public IActionResult Writer()
        {
            var result = tm.Listing();
            return View(result);
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
