using System.Collections.Generic;
using FirstWeb.Api.Models;

namespace FirstWeb.Api.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
