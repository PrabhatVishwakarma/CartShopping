using CartShopping.Models;
using Microsoft.EntityFrameworkCore;

namespace CartShopping.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category fruits = new Category { Name = "fruits", Slug = "fruits" };
                Category shirts = new Category { Name = "shirts", Slug = "shirt" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Apples",
                            Slug = "apple",
                            Description = "Very Sweet Apples",
                            Prize = 1.50M,
                            Category = fruits,
                            Image = "Apples.jpg"
                        },
                        new Product
                        {
                            Name = "Lemons",
                            Slug = "lemons",
                            Description = "this will make ur taste good",
                            Prize = 2M,
                            Category = fruits,
                            Image = "Lemon.jpg"
                        },
                        new Product
                        {
                            Name = "Watermelon",
                            Slug = "watermelon",
                            Description = "This is watermelon",
                            Prize = 0.50M,
                            Category = fruits,
                            Image = "Waterlemon.jpg"
                        },
                        new Product
                        {
                            Name = "Grapefruit",
                            Slug = "grapefruit",
                            Description = "Very Sweet Grapes",
                            Prize = 2.50M,
                            Category = fruits,
                            Image = "Grape.jpg"
                        },
                        new Product
                        {
                            Name = "Blue shirt",
                            Slug = "blue shirt",
                            Description = "This is blue Color Shirt",
                            Prize = 5.99M,
                            Category = shirts,
                            Image = "Blueshirt.jpg"
                        },
                        new Product
                        {
                            Name = "Black shirt",
                            Slug = "black shirt",
                            Description = "Looking hansome",
                            Prize = 7.99M,
                            Category = shirts,
                            Image = ".jpg"
                        },
                        new Product
                        {
                            Name = "Red shirt",
                            Slug = "red shirt",
                            Description = "You will look very smart",
                            Prize = 9.99M,
                            Category = shirts,
                            Image = "RedShirt.jpg"
                        },
                        new Product
                        {
                            Name = "Yellow shirt",
                            Slug = "yellow shirt",
                            Description = "Yellow Yellow Dirty Fellow",
                            Prize = 11.99M,
                            Category = shirts,
                            Image = "Yellowshirt.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}