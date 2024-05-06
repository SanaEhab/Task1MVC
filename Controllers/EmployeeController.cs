using Microsoft.AspNetCore.Mvc;
using Task1.Data;

namespace Task1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View("Index",result);
        }
    }
}
