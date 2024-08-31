using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
           
            var values = serviceManager.GetListT();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            
            serviceManager.AddT(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
           
            var values = serviceManager.GetByIdT(id);
            serviceManager.DeleteT(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            
            var values = serviceManager.GetByIdT(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            ViewBag.v1 = "Service List";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Update Service";
            serviceManager.UpdateT(service);
            return RedirectToAction("Index");
        }

    }
}
