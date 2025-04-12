using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext contex = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = contex.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            contex.Experiences.Add(experience);
            contex.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = contex.Experiences.Find(id);
            contex.Experiences.Remove(value);
            contex.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]

        public IActionResult UpdateExperience(int id)
        {
            var value = contex.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            contex.Experiences.Update(experience);
            contex.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
