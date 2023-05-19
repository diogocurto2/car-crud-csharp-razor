using car_crud_csharp_razor_model;

namespace car_crud_csharp_razor_services.UseCases.Outputs
{
    public class GetListCarsUseCaseOutput
    {
        public IEnumerable<Car> Cars { get; private set; }

        public GetListCarsUseCaseOutput(IEnumerable<Car> cars) 
        {
            this.Cars = cars;
        }
    }
}
