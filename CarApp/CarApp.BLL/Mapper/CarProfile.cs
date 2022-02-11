using AutoMapper;
using BLL.Models;
using DAL.Entities;

namespace CarAppBLL.Mapper
{
    class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarEntity, Car>();
        }
    }
}
