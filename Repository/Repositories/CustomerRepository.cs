using Microsoft.EntityFrameworkCore;
using Project_OOP.Core.Entities;
using Project_OOP.Core.Repositories;

namespace Project_OOP.Repository.Repositories
{
    internal class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext appDbContext, DbSet<Customer> dbSet) : base(appDbContext, dbSet)
        {
        }
    }
}
