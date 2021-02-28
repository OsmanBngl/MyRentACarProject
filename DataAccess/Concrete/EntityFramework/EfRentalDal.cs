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
                             join car in context.Cars
                             on rentals.CarId equals car.Id
                             join customer in context.Customers
                             on rentals.CustomerId equals customer.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join user in context.Users
                             on rentals.CarId equals user.Id
                             select new RentalDetailDto
                             {
                                 Id = rentals.Id,
                                 CarName = brand.BrandName,
                                 CustomerName = customer.CompanyName,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate
                             };
                return result.ToList();
            }
            
            
            
        }
    }
}
