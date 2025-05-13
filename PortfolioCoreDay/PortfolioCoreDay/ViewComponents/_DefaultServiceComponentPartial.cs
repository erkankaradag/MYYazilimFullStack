using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        PortfolioContext contex = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = contex.Services.Take(6).ToList();
            return View(values);
        }
    }
}
