using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresWebApp.Models
{
    public class WebAppContext: DbContext 
    {
        public WebAppContext(DbContextOptions<WebAppContext> options): base(options) { }

        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var now = DateTime.UtcNow;
            var books = new List<Book>()
            {
                new Book
                {
                    ID = 1,
                    Title = "Cloud Computing Business",
                    AuthorName = "Louise T Rice",
                    Release = now,
                    Price = 29,
                    Genre = "Techmology"
                },
                new Book
                {
                    ID = 2,
                    Title = "Cloud Computing Business",
                    AuthorName = "Louise T Rice",
                    Release = now,
                    Price = 29,
                    Genre = "Techmology"
                },
                new Book
                {
                    ID = 3,
                    Title = "Cloud Computing Business",
                    AuthorName = "Louise T Rice",
                    Release = now,
                    Price = 29,
                    Genre = "Techmology"
                },

            };

            modelBuilder.Entity<Book>().HasData(books);
        }
    }
}
