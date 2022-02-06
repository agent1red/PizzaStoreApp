namespace PizzaStoreApp.Interfaces
{
    public interface ICrustTypeRepository
    {
        Task<List<Crust>> GetAllCrustsAsync();
        Task<Crust> GetCrustByIdAsync(int id);
    }
}
