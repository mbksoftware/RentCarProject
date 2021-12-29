using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
        List<CarDetailsDto> GetCarDetails();
        void Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);
    }
}
