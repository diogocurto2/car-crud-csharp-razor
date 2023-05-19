namespace car_crud_csharp_razor_services.UseCases.Inputs
{
    public class EditCarUseCaseInput
    {
        public int Id { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Year { get; private set; }
        public int Doors { get; private set; }
        public string Color { get; private set; }
        public long Price { get; private set; }

        public EditCarUseCaseInput(int id, string make, string model, string year, int doors, string color, long price)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Doors = doors;
            Color = color;
            Price = price;
        }
    }
}
