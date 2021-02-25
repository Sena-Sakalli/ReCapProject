using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            //UsersTest();
            CarAdd();

        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.BrandName);
                }

            }
        }
    

        private static void UsersTest()
        {
            UsersManager user = new UsersManager(new EfUsersDal());
            user.Add(new Users { FirstName = "Sena", LastName = "Sakallı", Email = "senassakalli@gmail.com", Password = "12345" });

            var result = user.GetAll();

            if (result.Success)
            {
                foreach (var u in result.Data)
                {
                    System.Console.WriteLine(u.FirstName + " " + u.LastName);
                }
            }
        }

      

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetailDtos().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.DailyPrice);
                }

            }
            else 
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
