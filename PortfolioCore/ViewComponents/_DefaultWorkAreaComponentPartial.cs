using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultWorkAreaComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.WorkAreas.ToList();
            return View(values);
        }
    }
}
