using App.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.Data
{
    public static class DbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
            if (!context.Categories.Any())
            {
                SeedCategories(context);
            }

            if (!context.Posts.Any())
            {
                SeedPosts(context);
            }
        }

        private static void SeedCategories(AppDbContext context)
        {
            var categories = new[]
            {
                new Category { Name = "Category 1" },
                new Category { Name = "Category 2" },
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }

        private static void SeedPosts(AppDbContext context)
        {
            var posts = new[]
            {
                new Post { Title = "Post 1", Content = "Content 1", CategoryId = 1 },
                new Post { Title = "Post 2", Content = "Content 2", CategoryId = 2 },
            };

            context.Posts.AddRange(posts);
            context.SaveChanges();
        }

    }
}
