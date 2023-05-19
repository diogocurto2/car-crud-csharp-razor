using car_crud_csharp_razor_model;
using car_crud_csharp_razor_model.Interfaces;
using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;

namespace car_crud_csharp_razor_services.UseCases
{
    public class EditCarUseCase : IEditCarUseCase
    {
        private readonly ICarsRepository _CarsRepository;

        public EditCarUseCase(ICarsRepository carsRepository)
        {
            _CarsRepository = carsRepository;
        }

        public async Task Execute(EditCarUseCaseInput input)
        {
            var oldCar = await _CarsRepository.Get(input.Id);
            if (oldCar == null) { throw new Exception("Car do not exists."); }

            var car = new Car(
                input.Id,
                input.Make,
                input.Model,
                input.Year,
                input.Doors,
                input.Color,
                input.Price);

            await _CarsRepository.Update(car);
        }
    }
}
