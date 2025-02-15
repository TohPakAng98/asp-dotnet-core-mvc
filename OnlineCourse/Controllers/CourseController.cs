using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var model = Repository.Applications;
        return View(model);
    }
    
    public IActionResult Apply()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Apply( [FromForm] Candidate model)
    {
        if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
        {
            ModelState.AddModelError("Email", "E-mail already exists.");
        }
        
        if (ModelState.IsValid)
        {
            Repository.Add(model);
            return Redirect("/");
        }
        return View();
    }
}