

namespace PizzaStoreApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<BakeStyle> BakeStyles { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<CutStyle> CutStyles { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientType> IngredientTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PizzaItem> PizzaItems { get; set; }
        public DbSet<PizzaSide> PizzaSides { get; set; }
        public DbSet<PizzaSize> PizzaSizes { get; set; }
        public DbSet<PizzaSidePizzaItem> PizzaSidePizzaItems { get; set; }

    }
}
