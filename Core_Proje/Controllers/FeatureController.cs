using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Update Feature";
            ViewBag.v2 = "Features";
            ViewBag.v3 = "Feature Page";
            var values = featureManager.GetByIdT(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {

            featureManager.UpdateT(feature);
            return RedirectToAction("Index","Default");
        }

    }
}
