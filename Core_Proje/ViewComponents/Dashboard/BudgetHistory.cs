using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class BudgetHistory : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
