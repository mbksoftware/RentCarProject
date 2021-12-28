using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null);
        void Add(Brand car);
        void Delete(Brand car);
        void Update(Brand car);
    }
}
