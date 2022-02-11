using System.Collections.Generic;

namespace DAL.Entities
{
    public class CarModelEntity
    {
        public CarModelEntity()
        {
            Cars = new List<CarEntity>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int MarkId { get; set; }
        public CarMarkEntity Mark { get; set; }
        public ICollection<CarEntity> Cars { get; set; }
    }
}
