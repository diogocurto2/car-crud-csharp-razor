namespace car_crud_csharp_razor_services.UseCases.Inputs
{
    public class CreateCarUseCaseInput
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Year { get; private set; }
        public int Doors { get; private set; }
        public string Color { get; private set; }
        public long Price { get; private set; }

        public CreateCarUseCaseInput(string make, string model, string year, int doors, string color, long price)
        {
            Make = make;
            Model = model;
            Year = year;
            Doors = doors;
            Color = color;
            Price = price;
        }
    }
}
