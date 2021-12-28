using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal colorDal;
        public void Add(Color color)
        {
            colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            colorDal.Delete(color);
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return colorDal.GetAll(filter);
        }

        public void Update(Color color)
        {
            colorDal.Update(color);
        }
    }
}
