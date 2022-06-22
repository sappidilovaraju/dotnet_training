using Microsoft.AspNetCore.Mvc;
using FirstWeb.Api.Services.Interfaces;

namespace FirstWeb.Api.Controllers
{
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new JsonResult(_employeeService.GetEmployees());
        }
    }
}
