using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class WorkAreaController : Controller
    {
        PortfolioContext context= new PortfolioContext();
        public IActionResult WorkAreaList()
        {
            var values = context.WorkAreas.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatWorkArea() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreatWorkArea(WorkArea workArea) 
        {
            var value=context.WorkAreas.Add(workArea);
            context.SaveChanges();
            return RedirectToAction("WorkAreaList");
        }

        public IActionResult DeleteWorkArea(int id) 
        {
            var value = context.WorkAreas.Find(id);
            context.WorkAreas.Remove(value);
            context.SaveChanges();
            return RedirectToAction("WorkAreaList");
        }
    }
}
