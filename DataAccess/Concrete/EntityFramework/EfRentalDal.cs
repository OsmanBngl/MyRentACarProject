using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from rentals in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join user in context.Users
                             on rentals.Id equals user.Id
                             join brand in context.Brands
                             on rentals.Id equals brand.Id
                             select new RentalDetailDto
                        
                             {
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 BrandName = brand.BrandName,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate
                             };
                return result.ToList();
            }
            
            
            
        }
    }
}
