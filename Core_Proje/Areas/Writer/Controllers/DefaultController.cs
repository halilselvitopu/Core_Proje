using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{

    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        

        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementManager.GetListT();
            return View(values);
        }

        public IActionResult AnnouncementDetails(int id)
        { 
            Announcement announcement =  announcementManager.GetByIdT(id);
            return View(announcement); 
        }
    }
}
