using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Project List";
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values = portfolioManager.GetListT();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Add Project";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            ViewBag.v1 = "Project List";
            ViewBag.v2 = "Projects";
            ViewBag.v3 = "Add Project";
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult validationResult = validations.Validate(portfolio);
            if (validationResult.IsValid)
            {
                portfolioManager.AddT(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.GetByIdT(id);
            portfolioManager.DeleteT(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = portfolioManager.GetByIdT(id);
            ViewBag.v1 = "Update Portfolio";
            ViewBag.v2 = "Portfolios";
            ViewBag.v3 = "Update Portfolio";
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            PortfolioValidator validationRules = new PortfolioValidator();
            ValidationResult validationResult = validationRules.Validate(portfolio);
            if (validationResult.IsValid)
            {
                portfolioManager.UpdateT(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }
    }
}
