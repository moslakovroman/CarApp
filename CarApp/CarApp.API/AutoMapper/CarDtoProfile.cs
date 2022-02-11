using AutoMapper;
using BLL.Models;
using TestCarAppAPI.ViewModels;

namespace TestCarAppAPI.AutoMapper
{
    public class CarDtoProfile : Profile
    {
        public CarDtoProfile ()
        {
            CreateMap<Car, CarDto>();
        }
    }
}
