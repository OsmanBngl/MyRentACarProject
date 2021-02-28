using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
   public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarListed = "Arabalar Listelendi";


        public static string Add_Message(string text) => $@" {text}  Added";
        public static string Update_Message(string text) => $@"Updated the {text}";
        public static string Delete_Message(string text) => $@"Deleted the {text}";
        public static string Multiple_Add_Message(string text) => $@"Multiple {text}s  Added";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";


        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";



        public static string RentalAdded = "Araba Teslim Alındı";
        public static string RentalDeleted = "Araba Teslim edildi";
        public static string RentalUpdated = "Araba  güncellendi";
        public static string CarNameAlready="Araba ismi geçerli";
        public static string CarNameAlreadyExists="Araba ismi geçersiz";
        public static string CarPriceLimitExceded="Araba fiyatı geçerli";
        public static string CarPriceNotExists="Araba fiyatı geçersiz";
        public static string carImageAdded="Fotoğraf eklendi";
        public static string carImageDeleted= "Fotoğraf silindi";
        public static string carImageUpdated= "Fotoğraf güncellendi";
        public static string FailAddedImageLimit="Dosya limiti kadar resım yüklendi";
        public static string ImagesAdded="resim eklendi";

        public static string Car_Description_Minimum_Length = "Description must be at least 2 characters!";
        public static string Car_DailyPrice_Minimum_Limit = "Daily price must be greater than zero!";
        public static string Car_Must_Be_Rental = "Car must be rental before deliver the car";

        public static string Car_Must_Be_Lower_Than_5_Photos = "You reached the maximum image limit.";
        public static string Car_Must_Be_Exists = "The car doesnt exist.";
        public static string Car_Image_Must_Be_Exists = "The car image doesnt exist.";



        public static string Added = "Eklendi";
        public static string Updated = "Güncellendi";
        public static string Deleted = "Silindi";
        public static string CarCanNotBeRentError = "Araba şu anda kirada olduğu için tekrar kiralanamaz.";
        public static string ImageCountError = "En fazla 5 resim ekleyebilirsiniz.";
       

        
        public static string NotAdded = "Add process NOT OK";

        
        public static string NotDeleted = "Delete process NOT OK";

        
        public static string NotUpdated = "Update process NOT OK";

        public static string Listed = "List process OK";
        public static string NotListed = "List process NOT OK";

        public static string MaintenanceTime = "System is under maintenance";
        public static string FailedRental = "The car has not yet been delivered";
        public static string CarImageLimitExceeded = "More than 5 images cannot be added";
        public static string NoCarImages = "The car does NOT have any images";

    }
}
