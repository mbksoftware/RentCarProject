using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if(car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.CarName + " İsimli araba eklendi.");
            } else
            {
                Console.WriteLine(car.CarName + " İsimli araba eklenemedi.");
            }
           
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
           return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(p => p.ColorId == Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
