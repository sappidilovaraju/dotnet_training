using FirstWeb.Api.Services.Interfaces;
using FirstWeb.Api.Models;
using System.Collections.Generic;

namespace FirstWeb.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEnumerable<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Raju" },
                new Employee() { Id = 2, Name = "Test" }
            };
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
