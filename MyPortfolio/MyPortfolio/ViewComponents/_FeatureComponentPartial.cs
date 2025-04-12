using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContex = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContex.Features.ToList();
            return View(values);
        }
    }
}
