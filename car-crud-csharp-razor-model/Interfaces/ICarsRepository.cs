namespace car_crud_csharp_razor_model.Interfaces
{
    public interface ICarsRepository
    {
        Task<Car> Get(int id);
        Task<IEnumerable<Car>> GetAll();
        Task Remove(int id);
        Task Create(Car car);
        Task Update(Car car);
    }
}
