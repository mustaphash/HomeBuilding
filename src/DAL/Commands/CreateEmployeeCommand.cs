using Core.Commands;
using Core.Entity;

namespace DAL.Commands
{
    public class CreateEmployeeCommand : ICommand
    {
        public CreateEmployeeCommand(Employee employee)
        {
            Employee = employee;
        }
        public Employee Employee { get; set; }
    }
}
