namespace PizzaStoreApp.Data.Repositories
{
    public class PizzaBuilderRepository : IPizzaBuilderRepository
    {
        private readonly IDbContextFactory<DataContext> _context;
        public PizzaBuilderRepository(IDbContextFactory<DataContext> context)
        {
            _context = context;
        }


        public async Task<Pizza> CreatePizzaAsync(Pizza pizza)
        {
            using (var ctx = _context.CreateDbContext())
            {
                ctx.Pizzas.Add(pizza);
                await ctx.SaveChangesAsync();
                return pizza;
            }
        }

        public async Task<List<Pizza>> GetAllPizzasAsync()
        {
            using (var ctx = _context.CreateDbContext())
            {
                return await ctx.Pizzas.ToListAsync();

            }
        }

        public async Task<Pizza> GetPizzaByIdAsync(int id)
        {
            using (var ctx = _context.CreateDbContext())
            {
                var result = await ctx.Pizzas.FirstOrDefaultAsync(x => x.Id == id);
                if (result == null)
                {
                    return null;
                }
                return result;

            }
        }

        public async Task<Pizza> UpdatePizzaAsync(Pizza pizza)
        {
            using (var ctx = _context.CreateDbContext())
            {
                if (pizza == null)
                {
                    return null;
                }
                 ctx.Update(pizza);
                await ctx.SaveChangesAsync();
                return pizza;
            }
        }
    }
}
