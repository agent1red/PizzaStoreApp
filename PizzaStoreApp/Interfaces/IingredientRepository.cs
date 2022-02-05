

namespace PizzaStoreApp.Interfaces
{
    public interface IingredientRepository
    {
        Task<List<Ingredient>> GetAllIngredientsAsync();
        Task<Ingredient> GetIngredientByIdAsync(int id);
        Task<Ingredient> CreateIngredientAsync(Ingredient ingredient);
        Task<Ingredient> UpdateIngredientAsync(Ingredient ingredient);
    }
}
