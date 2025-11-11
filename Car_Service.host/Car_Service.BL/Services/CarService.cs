using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service.BL.Services
{
    internal class CarService:ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        void AddCar(Car car)
        {
            _carRepository.Add(car);
        }
        void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }
    }
}
