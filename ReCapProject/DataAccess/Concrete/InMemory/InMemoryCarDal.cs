using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()//constructor-ctor-
        {
            _cars = new List<Car> 
            {
                new Car {Id=1, BrandId=20, ColorId=10, ModelYear=2020, DailyPrice=250, Description="Auid"},
                new Car {Id=2, BrandId=21, ColorId=11, ModelYear=2002, DailyPrice=100, Description="BMW"},
                new Car {Id=3, BrandId=22, ColorId=12, ModelYear=2010, DailyPrice=120, Description="Mercedes"},
                new Car {Id=4, BrandId=23, ColorId=13, ModelYear=2016, DailyPrice=150, Description="Opel"},
                new Car {Id=5, BrandId=24, ColorId=14, ModelYear=2008, DailyPrice=110, Description="Seat"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c=>c.Id==car.Id); //Tek Tek dolaşma için foreach yerine
            _cars.Remove(carDelete);
        }
        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=>c.Id==carId).ToList();
        }

      
    }
}
