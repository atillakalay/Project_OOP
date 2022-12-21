using Microsoft.EntityFrameworkCore;
using Project_OOP.Core.Entities;
using Project_OOP.Core.Repositories;

namespace Project_OOP.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext, DbSet<Product> dbSet) : base(appDbContext, dbSet)
        {
        }
    }
}
