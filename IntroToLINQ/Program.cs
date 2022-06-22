using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroToLINQ
{
    internal class Program
    {
        static void Main()
        {
            //// The Three Parts of a LINQ Query:
            //// 1. Data source.
            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //// 2. Query creation.
            //// numQuery is an IEnumerable<int>
            ////var numQuery =
            ////    from num in numbers
            ////    where (num % 2) == 0
            ////    select num;

            //var numQuery = numbers.Where(n => n % 2 == 0);

            //// 3. Query execution.
            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0,1} ", num);
            //}

            var departments = GetDepartments();
            var employees = GetEmployees();

            //var resultedEmployess = employees.Where(x => x.Salary > 100000);
            //foreach (var employee in resultedEmployess)
            //{
            //    Console.WriteLine(employee.ToString());
            //}

            //var maxSalary = employees.Max(e => e.Salary);
            //var highestSalaryEmployee = employees.Where(e => e.Salary == maxSalary).FirstOrDefault();
            //Console.WriteLine(highestSalaryEmployee.ToString());

            //var sortedEmployess = employees.OrderByDescending(x => x.Name).ToList();
            //foreach (var employee in sortedEmployess)
            //{
            //    Console.WriteLine(employee.ToString());
            //}

            var employeeDepartments = (from emp in employees
                                      join dept in departments on emp.DepartmentId equals dept.Id
                                      select new
                                      {
                                          EmployeeName = emp.Name,
                                          DepartmentName = dept.Name,
                                      })
                                      .Where(x => x.DepartmentName == "IT")
                                      .Select(x => x.EmployeeName);

            foreach (var employee in employeeDepartments)
            {
                Console.WriteLine($"EmployeeName: {employee}");
            }

            //foreach (var employee in employeeDepartments)
            //{
            //    Console.WriteLine($"EmployeeName: {employee.EmployeeName}, DepartmentName: {employee.DepartmentName}");
            //}
        }

        static IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "John", DepartmentId = 2, Salary = 100000 },
                new Employee { Id = 2, Name = "Andy", DepartmentId = 3, Salary = 50000 },
                new Employee { Id = 3, Name = "Kishore", DepartmentId = 1, Salary = 60000 },
                new Employee { Id = 4, Name = "Raju", DepartmentId = 2, Salary = 200000 },
                new Employee { Id = 5, Name = "Mushahid", DepartmentId = 2, Salary = 150000 },
                new Employee { Id = 6, Name = "Jagan", DepartmentId = 1, Salary = 75000 },
            };
        }

        static IEnumerable<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department { Id = 1, Name = "Technical" },
                new Department { Id = 2, Name = "IT" },
                new Department { Id = 3, Name = "HR" }
            };
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
