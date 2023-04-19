using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreDemo.Models
{
    internal class ConfigureAuthors : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity) 
        {
            //seed initial data
            entity.HasData(
                new Author { AuthorId = 1, FirstName = "Michelle", LastName = "Alexander" },
                new Author { AuthorId = 2, FirstName = "Stephen E.", LastName = "Ambrose"},
                new Author { AuthorId = 3, FirstName = "Seth", LastName = "Grahame-Smith"}
                );
        }
    }
}
