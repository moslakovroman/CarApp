using AutoMapper;
using BLL.Models;
using BLL.Services.Inerfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestCarAppAPI.ViewModels;

namespace TestCarAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        private readonly IMapper _mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet]
        //[Route("[controller]")]
        public ActionResult GetCarsList()
        {
            var cars = _carService.GetAll();
            var carsDto = _mapper.Map<List<CarDto>>(cars);
            return Ok(carsDto);
        }

        [HttpGet("{id}")]
        public ActionResult GetCar(int id)
        {
            var car = _carService.Get(id);
            var carDto = _mapper.Map<CarDto>(car);
            return Ok(carDto);
        }
    }
}
