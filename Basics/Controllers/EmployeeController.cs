using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index1()
    {
        string message = $"Hello World. {DateTime.Now.ToString()}";
        return View("Index1", message);
    }

    public ViewResult Index2()
    {
        var names = new String[]
        {
            "Ahmet", "Mehmet", "Can"
        };
        return View(names);
    }

    public IActionResult Index3()
    {
        var list = new List<Employee>()
        {
            new Employee() { Id=1, FirstName="John", LastName="Doe", Age=30},
            new Employee() { Id=2, FirstName="Micheal", LastName="Yeoh", Age=47},
            new Employee() { Id=3, FirstName="Ahmet", LastName="Bustamam", Age=89}
        };
        return View("Index3", list);
    }
}