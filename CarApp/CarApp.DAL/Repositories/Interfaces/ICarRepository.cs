using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ICarRepository
    {
        List<CarEntity> GetAll();
        void Insert(CarEntity car);
        CarEntity Get(int carId);
        void Delete(int carId);
    }
}
