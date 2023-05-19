using car_crud_csharp_razor_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_crud_csharp_razor_services.UseCases.Outputs
{
    public class GetCarUseCaseOutput
    {
        public Car Car { get; private set; }

        public GetCarUseCaseOutput(Car car) 
        {
            this.Car = car;
        }
    }
}
