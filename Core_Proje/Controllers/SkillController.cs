using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {

            ViewBag.v1 = "Skill List";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Skill List";
            var values = skillManager.GetListT();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Add Skill";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Add Skill";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.AddT(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.GetByIdT(id);
            skillManager.DeleteT(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = skillManager.GetByIdT(id);
            ViewBag.v1 = "Update Skill";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Update Skill";
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            
            skillManager.UpdateT(skill);
            return RedirectToAction("Index");
        }

    }
}
