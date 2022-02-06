namespace PizzaStoreApp.Data.Repositories
{
    public class BakeStyleRepository : IBakeStyleRepository
    {
        private readonly IDbContextFactory<DataContext> _context;
        public BakeStyleRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }


        public async Task<List<BakeStyle>> GetAllBakeStylesAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.BakeStyles.ToListAsync();
                return result;

            }

        }

        public async Task<BakeStyle> GetBakeStyleByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {

                var result = await ctx.BakeStyles.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }
    }
}
