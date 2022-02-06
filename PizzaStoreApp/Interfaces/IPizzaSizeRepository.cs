namespace PizzaStoreApp.Interfaces
{
    public interface IPizzaSizeRepository
    {
        Task<List<PizzaSize>> GetAllPizzaSizesAsync();
        Task<PizzaSize> GetPizzaSizeByIdAsync(int id);
    }
}
