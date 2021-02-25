using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalsDal : EfEntityRepositoryBase<Rentals, RecapContext>, IRentalsDal
    {
        public List<RentalsDetailDto> GetDetailDto()
        {
            throw new NotImplementedException();
        }
    }
}
