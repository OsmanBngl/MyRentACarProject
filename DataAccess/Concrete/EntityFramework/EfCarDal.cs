using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentContext context=new CarRentContext())
            {
                var result = from brand in context.Brands
                             join car in context.Cars
                             on brand.Id equals car.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 CarName = car.Description,
                                 BrandName=brand.BrandName,
                                 ColorName=color.ColorName,
                                 DailyPrice= car.DailyPrice
                             };
                return result.ToList();
                

            }
        }
    }
}
