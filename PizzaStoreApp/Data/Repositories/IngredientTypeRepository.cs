namespace PizzaStoreApp.Data.Repositories
{
    public class IngredientTypeRepository : IIngredientTypeRepository
    {
        private readonly IDbContextFactory<DataContext> _context;

        public IngredientTypeRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }

        public async Task<IngredientType> CreateIngredientTypeAsync(IngredientType ingredientType)
        {
            using (var ctx = _context.CreateDbContext())
            {

                ctx.IngredientTypes.Add(ingredientType);
                await ctx.SaveChangesAsync();
                return ingredientType;
            }

        }

        public async Task<List<IngredientType>> GetAllIngredientTypesAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.IngredientTypes.ToListAsync();
                return result;


            }
        }
            public async Task<IngredientType> GetIngredientTypesByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {

                var result = await ctx.IngredientTypes.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }

        public async Task<IngredientType> UpdateIngredientTypeAsync(IngredientType ingredientType)
        {
            using (var ctx = _context.CreateDbContext())
            {
                if (ingredientType == null)
                {
                    return null;
                }
                ctx.Update(ingredientType);
                await ctx.SaveChangesAsync();
                return ingredientType;

            }
        }
    }
}
