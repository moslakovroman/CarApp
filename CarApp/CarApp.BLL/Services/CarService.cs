using AutoMapper;
using BLL.Models;
using BLL.Services.Inerfaces;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public Car Get(int id)
        {
            var carEntity = _carRepository.Get(id);
            var car = _mapper.Map<Car>(carEntity);
            return car;
        }
        public List<Car> GetAll()
        {
            var carEntities = _carRepository.GetAll();
            var cars = _mapper.Map<List<Car>>(carEntities).ToList();
            return cars;
        }
        public void Remove(int id)
        {
            _carRepository.Delete(id);
        }
    }
}
