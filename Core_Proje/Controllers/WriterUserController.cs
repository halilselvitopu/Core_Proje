using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.GetListT());
            return Json(values);
        }

        [HttpPost] 

        public IActionResult AddUser(WriterUser p)
        {
            writerUserManager.AddT(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetById(int id)
        {
            var v = writerUserManager.GetByIdT(id);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

    }
}
