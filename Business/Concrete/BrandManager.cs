using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal brandDal;

        public void Add(Brand brand)
        {
            brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            brandDal.Delete(brand);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return brandDal.GetAll(filter);
        }

        public void Update(Brand brand)
        {
            brandDal.Update(brand);
        }
    }
}
