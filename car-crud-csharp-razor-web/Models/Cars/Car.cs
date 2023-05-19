namespace car_crud_csharp_razor_web.Models.Cars
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Doors { get; set; }
        public string Color { get; set; }
        public long Price { get; set; }

        public Car() { }

        public Car(int id, string make, string model, string year, int doors, string color, long price)
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
