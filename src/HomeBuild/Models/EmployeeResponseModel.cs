using Core.Entity;

namespace HomeBuild.Models
{
    public class EmployeeResponseModel
    {
        public EmployeeResponseModel(Employee employee)
        {
            Id = employee.Id;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Adress = employee.Adress;
            PhoneNumber = employee.PhoneNumber;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
    }
}
