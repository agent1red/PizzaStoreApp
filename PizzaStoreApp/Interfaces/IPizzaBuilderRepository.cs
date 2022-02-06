namespace PizzaStoreApp.Interfaces
{
    public interface IPizzaBuilderRepository
    {
        Task<List<Pizza>> GetAllPizzasAsync();
        Task<Pizza> GetPizzaByIdAsync(int id);
        Task<Pizza> CreatePizzaAsync(Pizza pizza);
        Task<Pizza> UpdatePizzaAsync(Pizza pizza);
    }
}
