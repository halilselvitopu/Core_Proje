using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke() 
        {
            string p = "admin@gmail.com";
            
            var values = writerMessageManager.GetListReceiverMessage(p).TakeLast(3).ToList();
            Context c = new Context();

            foreach (var item in values)

            {

                var img = c.Users.Where(x => x.Email == item.Sender).Select(x => x.ImageUrl).FirstOrDefault();

                item.ImageUrl = img;

            }

            return View(values);
  
        }
    }
}
