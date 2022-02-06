namespace PizzaStoreApp.Interfaces
{
    public interface ICutStyleRepository
    {
        Task<List<CutStyle>> GetAllCutStylesAsync();
        Task<CutStyle> GetCutStyleByIdAsync(int id);
    }
}
