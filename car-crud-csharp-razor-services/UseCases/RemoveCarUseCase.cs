using car_crud_csharp_razor_model;
using car_crud_csharp_razor_model.Interfaces;
using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;

namespace car_crud_csharp_razor_services.UseCases
{
    public class RemoveCarUseCase : IRemoveCarUseCase
    {
        private readonly ICarsRepository _CarsRepository;

        public RemoveCarUseCase(ICarsRepository carsRepository)
        {
            _CarsRepository = carsRepository;
        }

        public async Task Execute(RemoveCarUseCaseInput input)
        {
            var oldCar = await _CarsRepository.Get(input.Id);
            if (oldCar == null) { throw new Exception("Car do not exists."); }

            await _CarsRepository.Remove(input.Id);

        }
    }
}
