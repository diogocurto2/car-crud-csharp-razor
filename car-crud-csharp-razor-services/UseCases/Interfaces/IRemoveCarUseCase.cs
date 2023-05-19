using car_crud_csharp_razor_services.UseCases.Inputs;

namespace car_crud_csharp_razor_services.UseCases.Interfaces
{
    public interface IRemoveCarUseCase
    {
        Task Execute(RemoveCarUseCaseInput input);
    }
}