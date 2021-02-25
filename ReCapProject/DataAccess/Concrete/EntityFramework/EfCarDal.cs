using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.Id equals b.Id
                             join co in context.Colors on c.Id equals co.Id
                             select new CarDetailDto 
                             { Id= c.Id, 
                               BrandName = b.Name, 
                               ColorName = co.Name,
                               DailyPrice = c.DailyPrice 
                             };

                return result.ToList();
            }

            

        }
    }
}
