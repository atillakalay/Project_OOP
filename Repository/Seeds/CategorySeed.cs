using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_OOP.Core.Entities;

namespace Project_OOP.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category() { Id = 1, Name = "Beyaz Eşya", CreatedDateTime = DateTime.Now }, new Category() { Id = 2, Name = "Televizyon", CreatedDateTime = DateTime.Now });
        }
    }
}
