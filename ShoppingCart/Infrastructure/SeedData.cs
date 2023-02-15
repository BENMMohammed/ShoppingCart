using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Infrastructure
{
        public class SeedData
        {
                public static void SeedDatabase(DataContext context)
                {
                        context.Database.Migrate();

                        if (!context.Products.Any())
                        {
                                Category phone = new Category { Name = "Phone", Slug = "phone" };
                                Category accesoire = new Category { Name = "Accesoire", Slug = "accesoire" };
                        }
                }
        }
}