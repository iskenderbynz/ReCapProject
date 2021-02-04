using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=130,ModelYear=2021,Description="Araba 1" },
                new Car {Id=2,BrandId=1,ColorId=2,DailyPrice=150,ModelYear=2021,Description="Araba 2" },
                new Car {Id=3,BrandId=2,ColorId=3,DailyPrice=100,ModelYear=2021,Description="Araba 3" },
                new Car {Id=4,BrandId=3,ColorId=2,DailyPrice=200,ModelYear=2021,Description="Araba 4" },
                new Car {Id=5,BrandId=3,ColorId=1,DailyPrice=500,ModelYear=2021,Description="Araba 5" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car toDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(toDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int car)
        {
            return _cars.Where(c => c.Id == car).ToList();
        }

        public void Update(Car car)
        {
            Car toUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            toUpdate.Id = car.Id;
            toUpdate.BrandId = car.BrandId;
            toUpdate.ColorId = car.ColorId;
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.ModelYear = car.ModelYear;
            toUpdate.Description = car.Description;
        }
    }
}
