using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ReaAkademiProje.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService tm;

        public TeamController(ITeamService tm)
        {
            this.tm = tm;
        }

        public IActionResult Index()
        {
            var result = tm.Listing();
            return View(result);
        }
    }
}
