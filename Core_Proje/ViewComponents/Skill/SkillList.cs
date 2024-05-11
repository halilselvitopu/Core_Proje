using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SkillManager skillMenager = new SkillManager(new EfSkillDal());
            var values = skillMenager.GetListT();
            return View(values);
        }
    }
}
