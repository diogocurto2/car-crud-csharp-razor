using car_crud_csharp_razor_model;
using car_crud_csharp_razor_model.Interfaces;
using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;
using car_crud_csharp_razor_services.UseCases.Outputs;

namespace car_crud_csharp_razor_services.UseCases
{
    public class GetCarUseCase : IGetCarUseCase
    {
        private readonly ICarsRepository _CarsRepository;

        public GetCarUseCase(ICarsRepository carsRepository)
        {
            _CarsRepository = carsRepository;
        }

        public async Task<GetCarUseCaseOutput> Execute(GetCarUseCaseInput input)
        {
            var result = await _CarsRepository.Get(input.Id);
            return new GetCarUseCaseOutput(result);
        }
    }
}
