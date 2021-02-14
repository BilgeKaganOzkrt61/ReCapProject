using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car{Id=1,BrandId=1,ColorId=10,ModelYear="2015",DailyPrice=150,Description="Full Gasoline and drophead"},
               new Car{Id=2,BrandId=1,ColorId=20,ModelYear="2017",DailyPrice=220,Description="drophead and 3.0 TDI"},
               new Car{Id=3,BrandId=2,ColorId=30,ModelYear="2010",DailyPrice=80,Description="ABS,AWD and 2.0 TDI"},
               new Car{Id=4,BrandId=2,ColorId=40,ModelYear="2012",DailyPrice=110,Description="Abs and 4x4"},
               new Car{Id=5,BrandId=3,ColorId=50,ModelYear="2021",DailyPrice=450,Description="SUV,4X4,ABS and 4.0 TDI"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=> c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
