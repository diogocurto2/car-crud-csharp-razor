
namespace car_crud_csharp_razor_web.Models.Cars
{
    public static class CarsMethods
    {

        public static car_crud_csharp_razor_web.Models.Cars.Car Convert(this car_crud_csharp_razor_model.Car car)
        {
            var result = new car_crud_csharp_razor_web.Models.Cars.Car(
                car.Id, 
                car.Make, 
                car.Model, 
                car.Year, 
                car.Doors, 
                car.Color, 
                car.Price);

            return result;
        }

        public static List<car_crud_csharp_razor_web.Models.Cars.Car> Convert(this IEnumerable<car_crud_csharp_razor_model.Car> list)
        {
            var result = new List<car_crud_csharp_razor_web.Models.Cars.Car>();

            foreach (var item in list)
            {
                var newCar = item.Convert();
                result.Add(newCar);
            }

            return result;
        }
    }
}
