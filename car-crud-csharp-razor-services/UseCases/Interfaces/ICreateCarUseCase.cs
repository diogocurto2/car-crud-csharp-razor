using car_crud_csharp_razor_services.UseCases.Inputs;

namespace car_crud_csharp_razor_services.UseCases.Interfaces
{
    public interface ICreateCarUseCase
    {
        Task Execute(CreateCarUseCaseInput input);
    }
}