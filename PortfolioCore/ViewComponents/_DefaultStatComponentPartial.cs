using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            Random rnd = new Random();
            int value1=rnd.Next(100,200);
            ViewBag.RndReferans=value1;
            ViewBag.PortfolioCnt = context.Portfolios.Count();
            ViewBag.SkillCnt=context.Skills.Count();
            int value2 = rnd.Next(10, 20);
            ViewBag.RndNumber = value2;

            return View();
        }
    }
}
