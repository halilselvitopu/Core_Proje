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

            var values = skillManager.GetListT();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            
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
