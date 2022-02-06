namespace PizzaStoreApp.Data.Repositories
{
    public class PizzaSizeRepository : IPizzaSizeRepository
    {
        private readonly IDbContextFactory<DataContext> _context;
        public PizzaSizeRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }


        public async Task<List<PizzaSize>> GetAllPizzaSizesAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.PizzaSizes.ToListAsync();
                return result;

            }
        }

        public async Task<PizzaSize> GetPizzaSizeByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {

                var result = await ctx.PizzaSizes.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }
    }
}
