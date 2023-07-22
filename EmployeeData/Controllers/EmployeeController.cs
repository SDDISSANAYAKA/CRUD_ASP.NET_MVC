using EmployeeData.DAL;
using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _context;
        private readonly object employeeList;

        public EmployeeController(EmployeeDBContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();

            if (employees != null)
            {
                List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
                foreach (var employee in employees)
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        id = employee.id,
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        dateOfBirth = employee.dateOfBirth,
                        email = employee.email,
                        salary = employee.salary

                    };
                    employeeList.Add(EmployeeViewModel);
                }
                return View(employeeList);
            }

            return View(employeeList);
        }
    }
}
