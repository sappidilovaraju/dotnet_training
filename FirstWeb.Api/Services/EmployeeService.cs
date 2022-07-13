﻿using FirstWeb.Api.Services.Interfaces;
using FirstWeb.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWeb.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Raju" },
                new Employee() { Id = 2, Name = "Test" }
            };
        }

        // Create
        public void CreateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new System.Exception("Employee is null");
            }

            _employees.Add(employee);
        }

        // Read
        public Employee GetEmployee(int id)
        {
            return _employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }

        // Update (Create/Update)
        public void UpdateEmployee(Employee employee)
        {
            var originalEmployee = GetEmployee(employee.Id);
            if (originalEmployee != null)
            {
                _employees.ForEach(item =>
                {
                    if (item.Id == employee.Id)
                    {
                        item.Name = employee.Name;
                    }
                });
            }
            else
            {
                _employees.Add(employee);
            }
        }

        // Delete
        public bool DeleteEmployee(int id)
        {
            _employees = _employees.Where(x => x.Id != id).ToList();
            return true;
        }
    }
}
