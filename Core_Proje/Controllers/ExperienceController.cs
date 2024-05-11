using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Experience List";
            ViewBag.v2 = "Experiences";
            ViewBag.v3 = "Experience List";
            var values = experienceManager.GetListT();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Add Experience";
            ViewBag.v2 = "Experiences";
            ViewBag.v3 = "Add Experience";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.AddT(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.GetByIdT(id);
            experienceManager.DeleteT(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = experienceManager.GetByIdT(id);
            ViewBag.v1 = "Update Experience";
            ViewBag.v2 = "Experiences";
            ViewBag.v3 = "Update Experience";
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {

            experienceManager.UpdateT(experience);
            return RedirectToAction("Index");
        }

    }
}
