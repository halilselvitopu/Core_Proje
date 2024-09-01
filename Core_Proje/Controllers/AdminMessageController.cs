using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult AdminMessageList(int id)
        {
            var values = writerMessageManager.GetByIdT(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            // Mesajı al
            var message = writerMessageManager.GetByIdT(id);

            
            if (message.SenderName == "admin@gmail.com") 
            {
                
                writerMessageManager.DeleteT(message);
                return RedirectToAction("SenderMessageList");
            }
            else
            { 
                writerMessageManager.DeleteT(message);
                return RedirectToAction("ReceiverMessageList");
            }
        }


        [HttpGet]
        public IActionResult AdminSendMessage()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AdminSendMessage(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageManager.AddT(p);
            return RedirectToAction("SenderMessageList");
        }

    }
}
