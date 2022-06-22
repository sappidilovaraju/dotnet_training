using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCwithASP.NET.Models;

namespace MVCwithASP.NET.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEnumerable<EmployeeViewModel> _employeeViewModels;

        public EmployeeController()
        {
            _employeeViewModels = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel { Id = 1, Name = "John", DepartmentId = 2, Salary = 100000 },
                new EmployeeViewModel { Id = 2, Name = "Andy", DepartmentId = 3, Salary = 50000 },
                new EmployeeViewModel { Id = 3, Name = "Kishore", DepartmentId = 1, Salary = 60000 },
                new EmployeeViewModel { Id = 4, Name = "Raju", DepartmentId = 2, Salary = 200000 },
                new EmployeeViewModel { Id = 5, Name = "Mushahid", DepartmentId = 2, Salary = 150000 },
                new EmployeeViewModel { Id = 6, Name = "Jagan", DepartmentId = 1, Salary = 75000 },
            };
        }

        public IActionResult Index()
        {
            return View(_employeeViewModels);
        }
    }
}
