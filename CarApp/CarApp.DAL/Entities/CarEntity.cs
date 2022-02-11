namespace DAL.Entities
{
    public class CarEntity
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Body { get; set; }
        public int Year { get; set; }
        public int Number { get; set; }
        public int ModelId { get; set; }
        public CarModelEntity Model { get; set; }
    }
}
