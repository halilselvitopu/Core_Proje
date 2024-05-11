using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetListT();
            return View(values);
        }
        
    }
}
