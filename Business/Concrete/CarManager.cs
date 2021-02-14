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
        public CarManager(ICarDal ıCardal)
        {
            _carDal= ıCardal;
        }


        public List<Car> GetAll()
        {
            return  _carDal.GetAll();
        }
    }
}
