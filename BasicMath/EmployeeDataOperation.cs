using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicMath
{
    public class EmployeeDataOperation : IDataInterface<Employee>
    {
        private List<Employee> employees;

        public EmployeeDataOperation()
        {
            employees = new List<Employee>();
        }

        public void Add(Employee entity)
        {
            employees.Add(entity);
        }

        public void Delete(Employee entity)
        {
            employees.Remove(entity);
        }

        public Employee Get(int id)
        {
            return employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
