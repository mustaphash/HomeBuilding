using Core.Commands;
using Core.Entity;
using Core.Queries;
using DAL.Commands;
using DAL.Queries.GetAllEmployees;
using HomeBuild.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeBuild.Controllers
{
    [Route("employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IQueryHandler<GetAllEmployeesQuery, IList<Employee>> _getAllEmployeesQuery;
        private readonly ICommandHandler<CreateEmployeeCommand> _createEmployeeCommand;
        public EmployeeController(
            IQueryHandler<GetAllEmployeesQuery, IList<Employee>> getAllEmployeesQuery,
            ICommandHandler<CreateEmployeeCommand> createEmployeeCommand)
        {
            _getAllEmployeesQuery = getAllEmployeesQuery;
            _createEmployeeCommand = createEmployeeCommand;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            IList<Employee> employees = await _getAllEmployeesQuery.HandleAsync(new GetAllEmployeesQuery());

            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeModel model)
        {
            var employee = model.ToEmployee();
            await _createEmployeeCommand.HandleAsync(new CreateEmployeeCommand(employee));

            return NoContent();
        }
    }
}
