using Microsoft.EntityFrameworkCore;
using nuova_pizza_ef_mvc.Models;

namespace nuova_pizza_ef_mvc
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options) { }
        public DbSet<Pizza>? Pizze { get; set; }
    }
}
