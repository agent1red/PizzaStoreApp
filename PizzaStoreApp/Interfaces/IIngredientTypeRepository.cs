namespace PizzaStoreApp.Interfaces
{
    public interface IIngredientTypeRepository
    {

        Task<List<IngredientType>> GetAllIngredientTypesAsync();
        Task<IngredientType> GetIngredientTypesByIdAsync(int id);
        Task<IngredientType> CreateIngredientTypeAsync(IngredientType ingredientType);
        Task<IngredientType> UpdateIngredientTypeAsync(IngredientType ingredientType);
    }
}
