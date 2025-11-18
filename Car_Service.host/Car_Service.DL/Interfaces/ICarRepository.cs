using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service.DL.Interface
{
    internal interface ICarRepository
    {
        void AddCar(Car car);
        void DeleteCar(int id);

        List<Car> GetAllCars();
    }
}
