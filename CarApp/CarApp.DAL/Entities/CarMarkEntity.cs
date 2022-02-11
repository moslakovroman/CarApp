using System.Collections.Generic;

namespace DAL.Entities
{
    public class CarMarkEntity
    {
        public CarMarkEntity()
        {
            CarModels = new List<CarModelEntity>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CarModelEntity> CarModels { get; set; }
    }
}
