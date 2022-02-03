using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear="1999", DailyPrice=5000 ,Description="test description"},
                new Car {Id=2, BrandId=2, ColorId=1, ModelYear="2005", DailyPrice=8000 ,Description="Boyasız hatasız "},
                new Car {Id=3, BrandId=2, ColorId=3, ModelYear="2008", DailyPrice=10000 ,Description="sağ ön kapı boyalı"},
                new Car {Id=4, BrandId=3, ColorId=2, ModelYear="2015", DailyPrice=140000 ,Description="80bin km'de hatasız"},
                new Car {Id=5, BrandId=3, ColorId=1, ModelYear="2022", DailyPrice=210000 ,Description="elektrikli son model"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.First (c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public void Delete(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.First(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
