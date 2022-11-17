using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReaAkademiProje.Controllers
{
    public class AdminController : Controller
    {
        TeamManager tm = new TeamManager(new TeamDal());
        [Authorize(Roles = "Admin")]
        public IActionResult List()
        {
            var values = tm.Listing();
            return View(values);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Team team)
        {
            tm.Adding(team);
            return RedirectToAction("List");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Teams.FirstOrDefault(o => o.teammate_ID == id);
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(Team team)
        {
            var result = tm.Updating(team);

            return RedirectToAction("List");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Teams.FirstOrDefault(o => o.teammate_ID == id);
                db.Teams.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("List");

        }


















        [HttpGet]
        public IActionResult Index(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Index(Team team)
        {
            Context c = new Context();
            var admin = c.Teams.FirstOrDefault(x => x.teammate_Name == team.teammate_Name && x.teammate_Password == team.teammate_Password);
            if (admin != null)
            {
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name,admin.teammate_Name),
                 new Claim(ClaimTypes.Role, admin.teammate_Role)
                };


                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);

                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("List", "Admin");
                }

            }

            return View();

        }
    }
}
