using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : EfEntityRepositoryBase<Users, RecapContext>, IUsersDal
    {
        public List<UsersDetailDto> GetDetailDto()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from u in context.Users
                             join cu in context.Customers
                             on u.Id equals cu.UsersId
                             select new UsersDetailDto
                             {
                                 UsersId = u.Id,
                                 FirsName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName,
                                 Email = u.Email
                             };
                return result.ToList();
            }
        }
    }

}
