namespace PizzaStoreApp.Data.Repositories
{
    public class CrustTypeRepository : ICrustTypeRepository
    {
        private readonly IDbContextFactory<DataContext> _context;
        public CrustTypeRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }
        public async Task<List<Crust>> GetAllCrustsAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.Crusts.ToListAsync();
                return result;

            }
        }

        public async Task<Crust> GetCrustByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {

                var result = await ctx.Crusts.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }
    }
}
