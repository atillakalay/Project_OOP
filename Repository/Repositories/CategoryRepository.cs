using Microsoft.EntityFrameworkCore;
using Project_OOP.Core.Entities;
using Project_OOP.Core.Repositories;

namespace Project_OOP.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext, DbSet<Category> dbSet) : base(appDbContext, dbSet)
        {
        }
    }
}
