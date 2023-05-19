namespace car_crud_csharp_razor_services.UseCases.Inputs
{
    public class RemoveCarUseCaseInput
    {

        public int Id { get; private set; }

        public RemoveCarUseCaseInput(int id)
        {
            Id = id;
        }
    }
}
