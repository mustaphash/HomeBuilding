namespace Core.Entity
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}
