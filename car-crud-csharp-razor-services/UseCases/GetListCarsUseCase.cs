using car_crud_csharp_razor_model;
using car_crud_csharp_razor_model.Interfaces;
using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Interfaces;
using car_crud_csharp_razor_services.UseCases.Outputs;

namespace car_crud_csharp_razor_services.UseCases
{
    public class GetListCarsUseCase : IGetListCarsUseCase
    {

        private readonly ICarsRepository _CarsRepository;

        public GetListCarsUseCase(ICarsRepository carsRepository)
        {
            _CarsRepository = carsRepository;
        }

        public async Task<GetListCarsUseCaseOutput> Execute(GetListCarsUseCaseInput input)
        {
            var result = await _CarsRepository.GetAll();
            return new GetListCarsUseCaseOutput(result);
        }
    }
}
