using car_crud_csharp_razor_services.UseCases.Inputs;
using car_crud_csharp_razor_services.UseCases.Outputs;

namespace car_crud_csharp_razor_services.UseCases.Interfaces
{
    public interface IGetCarUseCase
    {
        Task<GetCarUseCaseOutput> Execute(GetCarUseCaseInput input);
    }
}