using Core.Entity;
using Core.Queries;
using DAL.Queries.GetAllEmployees;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuild.Controllers
{
    [Route("employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IQueryHandler<GetAllEmployeesQuery, IList<Employee>> _getAllEmployeesQuery;
        public EmployeeController(
            IQueryHandler<GetAllEmployeesQuery, IList<Employee>> getAllEmployeesQuery)
        {
            _getAllEmployeesQuery = getAllEmployeesQuery;
        }

        [HttpGet(Name = "GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            IList<Employee> employees = await _getAllEmployeesQuery.HandleAsync(new GetAllEmployeesQuery());

            return Ok(employees);
        }
    }
}
