using BusinessLayer.Concrete;
using Core_Proje.Areas.Writer.Controllers;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.GetListT();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values =messageManager.GetByIdT(id);
            messageManager.DeleteT(values);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var values = messageManager.GetByIdT(id);
            return View(values);
        }
    }
}
