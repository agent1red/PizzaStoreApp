namespace PizzaStoreApp.Data.Repositories
{
    public class CutStyleRepository : ICutStyleRepository
    {
        private readonly IDbContextFactory<DataContext> _context;
        public CutStyleRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }


        public async Task<List<CutStyle>> GetAllCutStylesAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.CutStyles.ToListAsync();
                return result;

            }

        }

        public async Task<CutStyle> GetCutStyleByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {

                var result = await ctx.CutStyles.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;
            }
        }
    }
}
