﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.GetListT());
            return Json(values);
        }

        [HttpPost]

        public IActionResult AddExperience(Experience p)
        {
            experienceManager.AddT(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}