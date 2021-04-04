using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length <= 1 && car.DailyPrice < 0)
            {
                Console.WriteLine("Hata!. Araba ismi mininum 2 karakter olmalıdır ve günlük ücretinizin 0 dan büyük olmalı ");
            }
            else if (car.Description.Length >= 2 && car.DailyPrice <= 0)
            {
                Console.WriteLine("Hata!. Araba günlük fiyatı 0' dan büyük olmalıdır.");
            }
            else if (car.Description.Length <= 1 && car.DailyPrice > 0)
            {
                Console.WriteLine("Hata!. Araba günlük fiyatı 0' dan büyük olmalıdır.");
            }
            else 
            {
                _carDal.Add(car);
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car );
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByCategoryId(int ıd)
        {
            return _carDal.GetAll(p => p.BrandId == ıd);
        }

        public List<Car> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int ıd)
        {
            return _carDal.GetAll(p => p.BrandId == ıd);
        }

        public List<Car> GetCarsByColorId(int ıd )
        {
            return _carDal.GetAll(p => p.ColorId == ıd);
        }

        public void Update(Car  car)
        {
            _carDal.UpDate(car);
        }
    }
}
