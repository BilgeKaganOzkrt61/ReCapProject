using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id);
                Console.WriteLine("BrandId : " +car.BrandId);
                Console.WriteLine("ColorId : " +car.ColorId);
                Console.WriteLine("ModelYear : " + car.ModelYear);
                Console.WriteLine("DailyPrice : " + car.DailyPrice);
                Console.WriteLine("Features : " +car.Description);
                Console.WriteLine("--------------");
                //Kendim fazlalık olarak eklediğim bölümler var.
            }
        }
    }
}
