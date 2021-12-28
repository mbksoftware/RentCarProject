using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var addedEntry = context.Entry(entity);
                addedEntry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var deletedEntry = context.Entry(entity);
                deletedEntry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using(RentCarContext context = new RentCarContext())
            {
                return context.Set<Car>().FirstOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetById(int id)
        {
            using (RentCarContext context = new RentCarContext())
            {
               Car gettedCar = context.Set<Car>().ToList().Where(p => p.CarId == id).FirstOrDefault();
               return gettedCar;
            }
        }

        public void Update(Car entity)
        {
            using(RentCarContext context = new RentCarContext())
            {
              var updatedCar =  context.Set<Car>().ToList().Where(p => p.CarId == entity.CarId);
                Car car = (Car)updatedCar;
                car = entity;
            }
        }
    }
}
