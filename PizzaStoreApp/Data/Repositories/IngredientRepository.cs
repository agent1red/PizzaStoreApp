

namespace PizzaStoreApp.Data.Repositories
{
    public class IngredientRepository : IingredientRepository
    {
        private readonly IDbContextFactory<DataContext> _context;

        public IngredientRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }


        public async Task<Ingredient> CreateIngredientAsync(Ingredient ingredient)
        {
            using (var ctx = _context.CreateDbContext())
            {
               
                ctx.Ingredients.Add(ingredient);
                await ctx.SaveChangesAsync();
                return ingredient;
            }

        }

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
        
                using (var ctx = _context.CreateDbContext())
                {
                    var result = await ctx.Ingredients.ToListAsync();
                    return result;

                }
         

            
        }
        public async Task<Ingredient> GetIngredientByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {

                var result = await ctx.Ingredients.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }
        public async Task<Ingredient> UpdateIngredientAsync(Ingredient ingredient)
        {
            using (var ctx = _context.CreateDbContext())
            {
                if (ingredient == null)
                {
                    return null;
                }
                ctx.Update(ingredient);
                await ctx.SaveChangesAsync();
                return ingredient;

            }
        }
    }
}
