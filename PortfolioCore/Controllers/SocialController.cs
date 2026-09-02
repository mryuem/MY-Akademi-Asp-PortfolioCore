using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SocialController : Controller
    {
        PortfolioContext context=new PortfolioContext();

        public IActionResult SocialList()
        {
            var values=context.Socials.ToList();
            return View(values);
        }
        [HttpGet]
        public  IActionResult CreateSocial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocial(Social social)
        {
            context.Socials.Add(social);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }
        public IActionResult DeleteSocial(int id)
        {
            var value= context.Socials.Find(id);
            context.Socials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }
        [HttpGet]
        public IActionResult UpdateSocial(int id)
        {  
            var value=context.Socials.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocial(Social social)
        {
            context.Socials.Update(social);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }
    }
}
