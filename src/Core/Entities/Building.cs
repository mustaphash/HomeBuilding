namespace Core.Entity
{
    public class Building
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int MaterialId { get; set; }
        public int BrigadeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Place Place { get; set; }
        public Material Material { get; set; }
        public Brigade Brigade { get; set; }
    }
}
