using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>()
            {
                new Car() {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 1500, Description = "BMW Car", ModelYear = "2005"},
                new Car() {CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 1000, Description = "Renault Car", ModelYear = "2002"},
                new Car() {CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 1400, Description = "Fiat Car", ModelYear = "2010"},
                new Car() {CarId = 4, BrandId = 5, ColorId = 1, DailyPrice = 1350, Description = "Ford Car", ModelYear = "2002"},
                new Car() {CarId = 5, BrandId = 3, ColorId = 1, DailyPrice = 1800, Description = "BMW Car", ModelYear = "1900"},

            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletingCar = cars.FirstOrDefault(p => p.CarId == car.CarId);
            cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car gettingCar = cars.FirstOrDefault(p=> p.CarId == id);
            return gettingCar;
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.FirstOrDefault(p => p.CarId == car.CarId);
            carToUpdate = car;
        }
    }
}
