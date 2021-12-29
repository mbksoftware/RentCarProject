using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentCarContext>, IColorDal
    {
     
    }
}
