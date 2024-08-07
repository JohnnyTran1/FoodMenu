using Microsoft.EntityFrameworkCore;
using Menu.Models;

namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext( DbContextOptions<MenuContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredeient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
