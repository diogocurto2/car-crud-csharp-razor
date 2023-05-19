using car_crud_csharp_razor_infra.Context;
using car_crud_csharp_razor_model;
using car_crud_csharp_razor_model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace car_crud_csharp_razor_infra
{
    public class CarsRepositoryInMemory : ICarsRepository
    {

        private readonly CarsContextInMemory _context;

        public CarsRepositoryInMemory() 
        {
            _context = new CarsContextInMemory();
        }

        public async Task Create(Car car)
        {
            int id = _context.cars.Count + 1;
            _context.cars.Add(car);
        }

        public async Task<Car> Get(int id) => _context.cars.FirstOrDefault(c => c.Id == id);

        public async Task<IEnumerable<Car>> GetAll() => _context.cars.ToList();

        public async Task Remove(int id)
        {
            var result = await this.Get(id);
            _context.cars.Remove(result);
        }

        public async Task Update(Car car)
        {
            var result = await this.Get(car.Id);
            _context.cars.Remove(result);
            _context.cars.Add(car);
        }
    }
}
