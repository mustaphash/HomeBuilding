namespace Core.Entity
{
    public class Brigade
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}
