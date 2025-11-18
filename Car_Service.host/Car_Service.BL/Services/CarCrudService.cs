using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service.BL.Services
{
    internal class CarCrudService:ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarCrudService(ICarRepository carRepository)
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
        public Car_Service? GetId(int id) { 
        return _carRepository.GetById(id);
        }
    }
}
