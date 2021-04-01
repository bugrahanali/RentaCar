using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete();
        void Update();
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int ıd);
        List<Car> GetAllByUnitPrice(decimal min, decimal max);
        List<Car> GetCarsByBrandId(int ıd);
        List<Car> GetCarsByColorId(int ıd);
    }
}
