using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var item in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(item.Id + " " + item.BrandId + "   " + item.ColorId + "    " + item.DailyPrice + "    " + item.ModelYear + "    " + item.Description);
            //}

            //Console.WriteLine("-------------------------------------------------------------------");
            //foreach (var car in carManager.GetCarsByColorId(3))
            //{
            //    Console.WriteLine(car.Id + "     " + car.BrandId + "          " + car.ColorId + "      " + car.DailyPrice + "        " + car.ModelYear + "     " + car.Description);
            //}




            //carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = 2019, DailyPrice = 200, Description = "T" });
            //carManager.Add(new Car {  BrandId = 3, ColorId = 4, ModelYear = 2018, DailyPrice = 0, Description = "tor" });


            //foreach (var item in carManager.GetById(1))
            //{
            //    Console.WriteLine(item.Description+ " " +item.DailyPrice+" "+item.ColorId);
            //}

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description + " " + item.DailyPrice + " " + item.ColorId);
            //}


            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "BUGATTİ" });
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorId = 9, ColorName = "Beyaz" });
            //colorManager.Add(new Color { ColorId = 10, ColorName = "Mavi" });
            //colorManager.Add(new Color { ColorId = 11, ColorName = "Kırmızı" });
            //colorManager.Add(new Color { ColorId = 12, ColorName = "Siyah" });
            //colorManager.Add(new Color { ColorId = 13, ColorName = "Mor" });
            //colorManager.Add(new Color { ColorId = 14, ColorName = "Siyah" });

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorId + " " + color.ColorName);
            //}

            ////ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(new Color { ColorId = 6 });

            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.ColorId + " " + item.ColorName);
            //}

            //foreach (var item in colorManager.GetById(12))
            //{
            //    Console.WriteLine(item.ColorId + " " + item.ColorName);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var item in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(item.BrandName + " " + item.CarName + "  " + item.DailyPrice + "  " + item.ColorName);
            //}


            //CarManager carManager = new CarManager(new EfCarDal());

            //var result= carManager.Add(new Car {  BrandId = 23, ColorId = 23, Description = "Hyundai", DailyPrice = 220, ModelYear = 2010 });




            // foreach (var item in result.Messages)
            // {
            //     Console.WriteLine(result.Messages);
            // }
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetAll();

            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.Description+ " " +item.BrandId+ " " +item.ColorId+ " " + item.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Messages);
            //}

            //var result1 = carManager.GetById(5);

            //if (result1.Success)
            //{


            //        Console.WriteLine(result1.Data);

            //}


            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { RentalId = 1, CarId = 2, CustomerId = 3, RentDate =DateTime.Now, ReturnDate = DateTime.Now });

            ////rentalManager.Add(new Rental { RentalId = 1, CarId = 2, CustomerId = 3, RentDate = 2021 / 02 / 20, ReturnDate = 2021\02\22 });

            //foreach (var item in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.CarId+ " " +item.CustomerId+""+item.RentalId+""+item.RentDate+""+item.ReturnDate);
            //}

        }
    }
}
