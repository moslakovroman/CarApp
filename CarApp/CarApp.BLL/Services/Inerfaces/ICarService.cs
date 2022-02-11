using BLL.Models;
using System.Collections.Generic;

namespace BLL.Services.Inerfaces
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car Get(int id);
        void Remove(int id);
    }
}
