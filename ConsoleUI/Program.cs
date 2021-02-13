using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetByDailyPriceTest();



            //AddTest();


            UpdateTest();
            GetCarDetailsTest();



        }

        private static void AddTest()
        {
            Car car = new Car
            {
                CarName = "190 D",
                ColorId = 2,
                BrandId = 1,
                ModelYear = 1987,
                DailyPrice = 110,
                Description = "Mercedes w201 modeli 190 D"
            };

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
        }

        private static void UpdateTest()
        {
            Car car = new Car
            {
                CarName = "190 D",
                ColorId = 2,
                BrandId = 1,
                ModelYear = 1987,
                DailyPrice = 110,
                Description = "Mercedes w201 modeli 190 D"
            };

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(car);
        }



        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.BrandName);
                Console.WriteLine(car.ColorName);
                Console.WriteLine(car.DailyPrice);
            }
        }

        private static void GetByDailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(50, 150))
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
