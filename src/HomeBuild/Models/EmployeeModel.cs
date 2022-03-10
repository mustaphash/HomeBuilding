using Core.Entity;

namespace HomeBuild.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }

        public Employee ToEmployee()
        {
            return new Employee()
            {
                FirstName = FirstName,
                LastName = LastName,
                Adress = Adress,
                PhoneNumber = PhoneNumber
            };
        }
    }
}
