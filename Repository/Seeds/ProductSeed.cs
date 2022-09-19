using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_OOP.Core.Entities;

namespace Project_OOP.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product() { CategoryId = 1, Id = 1, Name = "Buzdolabı", Price = 8500, CreatedDateTime = DateTime.Now });
        }
    }
}
