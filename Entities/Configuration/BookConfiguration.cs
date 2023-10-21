using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
            (
                new Book
                {
                    Id = new Guid("cac88bc1-6134-4cbd-9697-0cc8b09312f6"),
                    Name = "О дивный новый мир",
                    Qenre = "Антиутопия",
                    YearIssue = 1931,
                    AuthorId = new Guid("64ace7ab-26a0-4429-8d8c-2209d83e9c62")
                },
                new Book
                {
                    Id = new Guid("ed7f465c-6529-49f7-8b5b-1ce9ec3b006a"),
                    Name = "Скотный двор",
                    Qenre = "Повесть",
                    YearIssue = 1945,
                    AuthorId = new Guid("64ace7ab-26a0-4429-8d8c-2209d83e9c62")
                },
                new Book
                {
                    Id = new Guid("9f9e418e-bce4-41ec-950f-d7770aa6bcfb"),
                    Name = "1984",
                    Qenre = "Роман-антиутопия",
                    YearIssue = 1949,
                    AuthorId = new Guid("75e02071-4510-4f5a-a80a-8545f6470a06")
                }
            );
        }
    }
}
