using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultProjectComponenetPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke(int categoryId=0)
        {
              var projects=context.Portfolios.Where(x=>categoryId == 0 || x.CategoryId == categoryId).ToList();
              return View(projects);
        }
    }
}
