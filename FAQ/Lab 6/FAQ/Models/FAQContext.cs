﻿using FAQ.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQ.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Topic> Topics { get; set; } = null!;

        public DbSet<FAQ> FAQs { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "gen", Name = "General" },
                new Category { CategoryId = "hist", Name = "History" });

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "cs", Name = "C#" },
                new Topic { TopicId = "js", Name = "JavaScript" },
                new Topic { TopicId = "boot", Name = "Bootstrap" }
                );
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    Id = 1,
                    Question = "What is C#?",
                    Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.",
                    TopicId = "cs",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 2,
                    Question = "When was C# first released?",
                    Answer = "In 2002.",
                    TopicId = "cs",
                    CategoryId = "hist"
                },
                new FAQ
                {
                    Id = 3,
                    Question = "What is JavaScript?",
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    TopicId = "js",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 4,
                    Question = "When was JavaScript first released?",
                    Answer = "In 1995.",
                    TopicId = "js",
                    CategoryId = "hist"
                },
                new FAQ
                {
                    Id = 5,
                    Question = "What is Bootstrap?",
                    Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    TopicId = "boot",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 6,
                    Question = "When was Bootstrap first released?",
                    Answer = "In 2011.",
                    TopicId = "boot",
                    CategoryId = "hist"
                }
                );
        }
    }
}