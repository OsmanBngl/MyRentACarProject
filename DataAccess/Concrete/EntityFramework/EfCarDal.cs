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
        public List<CarDetailDto> GetCarDetails(int id)
        {
            using (CarRentContext context=new CarRentContext())
            {
                var result = from brand in context.Brands
                             join car in context.Cars
                             on brand.Id equals car.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join im in context.CarImages
                             on car.Id equals im.CarId
                            // where car.CarId == carId
                            
                             where car.Id==id
                            
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandName=brand.BrandName,
                                 ColorName=color.ColorName,
                                 DailyPrice= car.DailyPrice,
                                 ModelYear=car.ModelYear,
                                 Description=car.Description,
                                 ImagePath= im.ImagePath
                                 
                             };
                return result.ToList();
                

            }
        }



        public List<CarDetailDto> GetCarDetails2(Expression<Func<CarDetailDto, bool>> filter = null)
        {

            using (CarRentContext context = new CarRentContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                                 on car.BrandId equals b.Id
                             join color in context.Colors
                                 on car.ColorId equals color.Id
                             //join image in context.CarImages
                             //on car.CarId equals image.CarId

                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId=b.Id,
                                 ColorId=color.Id,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 ImagePath = (from carImage in context.CarImages where carImage.CarId == car.Id select carImage.ImagePath).FirstOrDefault()

                             };
                return filter==null? result.ToList():result.Where(filter).ToList();
            }
        }

       
    }
}
