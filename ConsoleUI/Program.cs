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
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car() { CarName = "Ford", BrandId = 5, DailyPrice = 700, Description = "2002 Model Car", ColorId = 3, ModelYear = "2002" });
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka : " + car.BrandName + "Renk : " + car.ColorName);
            }
        }
    }
}
