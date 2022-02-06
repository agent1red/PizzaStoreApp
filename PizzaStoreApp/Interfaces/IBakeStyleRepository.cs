namespace PizzaStoreApp.Interfaces
{
    public interface IBakeStyleRepository
    {
        Task<List<BakeStyle>> GetAllBakeStylesAsync();
        Task<BakeStyle> GetBakeStyleByIdAsync(int id);
    }
}
