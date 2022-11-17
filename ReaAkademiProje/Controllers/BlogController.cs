using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace ReaAkademiProje.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService bl;
        public BlogController(IBlogService bl)
        {
            this.bl = bl;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult List()
        {
            var values = bl.Listing();
            return View(values);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Blog blog)
        {
            bl.Adding(blog);
            return RedirectToAction("List");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Blogs.FirstOrDefault(o => o.blog_ID== id);
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(Blog blog)
        {
            var result = bl.Updating(blog);

            return RedirectToAction("List");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Blogs.FirstOrDefault(o => o.blog_ID == id);
                db.Blogs.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("List");

        }
    }
}
