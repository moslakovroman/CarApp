using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    public class CarRepository : ICarRepository
    {

        private readonly CarAppDbContext _dbContext;

        public CarRepository(CarAppDbContext dbContex)
        {
            _dbContext = dbContex;
        }
        public CarEntity Get(int id)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Id == id);
            return car;
        }

        public List<CarEntity> GetAll()
        {
            var cars = _dbContext.Cars.ToList();
            return cars;
        }

        public void Insert(CarEntity car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public void Delete(int carId)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Id == carId);
            _dbContext.Remove(car);
            _dbContext.SaveChanges();
        }
    }
}
