namespace car_crud_csharp_razor_services.UseCases.Inputs
{
    public class GetCarUseCaseInput
    {

        public int Id { get; private set; }

        public GetCarUseCaseInput(int id)
        {
            Id = id;
        }
    }
}
