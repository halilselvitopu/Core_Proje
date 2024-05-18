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
            ViewBag.v1 = "Service List";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Service List";
            var values = serviceManager.GetListT();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Add New Service";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Add New Service";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            ViewBag.v1 = "Add New Service";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Add New Service";
            serviceManager.AddT(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            ViewBag.v1 = "Service List";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Delete Service";
            var values = serviceManager.GetByIdT(id);
            serviceManager.DeleteT(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.v1 = "Update Service";
            ViewBag.v2 = "Services";
            ViewBag.v3 = "Update Service";
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
