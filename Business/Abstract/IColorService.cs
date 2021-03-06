using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll(Expression<Func<Color, bool>> filter = null);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
