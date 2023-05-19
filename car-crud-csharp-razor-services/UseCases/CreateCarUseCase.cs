using car_crud_csharp_razor_model;
using car_crud_csharp_razor_model.Interfaces;
using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;

namespace car_crud_csharp_razor_services.UseCases
{
    public class CreateCarUseCase : ICreateCarUseCase
    {
        private readonly ICarsRepository _CarsRepository;

        public CreateCarUseCase(ICarsRepository carsRepository)
        {
            _CarsRepository = carsRepository;
        }

        public async Task Execute(CreateCarUseCaseInput input)
        {
            var car = new Car(
                input.Make,
                input.Model,
                input.Year,
                input.Doors,
                input.Color,
                input.Price);

            await _CarsRepository.Create(car);
        }
    }
}
