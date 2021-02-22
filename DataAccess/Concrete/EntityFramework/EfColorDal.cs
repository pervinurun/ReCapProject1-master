using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
   public  class EfColorDal : EfEntityRepositoryBase<Color, Context>, IColorDal
    {
        
    }
}
