using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcoreempty1.modal
{
    public class MockCarRepository : ICarRepository
    {
        public List<Car> _car = new List<Car>();
        public MockCarRepository() {
            _car.Add(new Car { id = 1, name = "BMW", price = 24000000, model = "X5" });
            _car.Add(new Car { id = 2, name = "ROLCE ROYCE", price = 9000000, model = "Ghost" });
            _car.Add(new Car { id = 3, name = "Mercedez Benz", price = 4000000, model = "GLC" });
            _car.Add(new Car { id = 4, name = "Renault", price = 9000000, model = "KWID" });
            _car.Add(new Car { id = 5, name = "Lamborgini", price = 2000000, model = "Urus" });
        }
        Car ICarRepository.GetCar(int id) {
            return _car.FirstOrDefault(e => e.id == id);

        }
    }
}