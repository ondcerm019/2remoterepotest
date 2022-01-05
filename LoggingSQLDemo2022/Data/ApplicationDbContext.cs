using LoggingSQLDemo2022.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSQLDemo2022.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Company> Companies { get; set; }

        public ApplicationDbContext() : base() {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=myDatabaseFile.sqlite");
            // https://docs.microsoft.com/en-us/ef/core/logging-events-diagnostics/simple-logging
            // options.LogTo(Console.WriteLine, new[] { /*CoreEventId.ContextInitialized,*/ RelationalEventId.CommandExecuted });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>().HasData(new Company { CompanyId = 1, Name = "CD Project" });
            modelBuilder.Entity<Company>().HasData(new Company { CompanyId = 2, Name = "Id Software" });
            modelBuilder.Entity<Game>().HasData(new Game { GameId = 1, Name = "Witcher: Wild Hunt", Realeased=new DateTime(2015,5,18), DeveloperId=1 });
            modelBuilder.Entity<Game>().HasData(new Game { GameId = 2, Name = "Cyberpunk 2077", Realeased = new DateTime(2020,9,17), DeveloperId=1 });
            modelBuilder.Entity<Game>().HasData(new Game { GameId = 3, Name = "Doom", Realeased = new DateTime(1993, 12, 10), DeveloperId=2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 1, Text = "RPG", GameId = 1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 2, Text = "Fantasy", GameId = 1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 3, Text = "Action", GameId = 1 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 4, Text = "RPG", GameId = 2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 5, Text = "Cyberpunk", GameId = 2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 6, Text = "Action", GameId = 2 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 7, Text = "Shooter", GameId = 3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 8, Text = "Action", GameId = 3 });
            modelBuilder.Entity<Tag>().HasData(new Tag { TagId = 9, Text = "Sci-fi", GameId = 3 });
        }
    }
}
