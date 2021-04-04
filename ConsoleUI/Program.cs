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
            Car car1 = new Car { CarId = 1,MoldelYear=2021, CarName = "Tesla", BrandId = 1, ColorId = 1,DailyPrice=321231,Description="sade mi sade ", };

            CarManager carManager = new CarManager(new EfCarDal());
                
            carManager.Add(car1);
           
        }
    }
}
