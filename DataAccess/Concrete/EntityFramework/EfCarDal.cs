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
                var result = from cbr in context.Brands
                             join c in context.Cars
                             on cbr.BrandId equals c.BrandId
                             join cco in context.Colors
                             on c.ColorId equals cco.ColorId
                             select new CarDetailDto
                             {
                                 CarName = c.Description,
                                 BrandName=cbr.BrandName,
                                 ColorName=cco.ColorName,
                                 DailyPrice= c.DailyPrice
                             };
                return result.ToList();
                

            }
        }
    }
}
