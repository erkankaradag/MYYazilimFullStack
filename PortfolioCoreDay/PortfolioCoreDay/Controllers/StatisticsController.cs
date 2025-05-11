using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v4 = context.Skills.Where(x =>  x.SkillValue > 80).Count();
            return View();
        }
    }
}
