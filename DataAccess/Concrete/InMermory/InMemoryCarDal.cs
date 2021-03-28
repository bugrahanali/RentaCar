using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMermory
{
    class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,CarName="BMW", BrandId= 1, ColorId=1,DailyPrice=1212, Description="yepisyeni",MoldelYear=2020 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =   carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetById(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void UpDate(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.MoldelYear = car.MoldelYear ;



        }
    }
}
