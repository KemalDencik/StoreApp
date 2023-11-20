using Microsoft.EntityFrameworkCore;

namespace StoreApp.Model
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) :base(options)//dbcontext le gelmeyen ifade newlenmez
        {
            
        }
    }
}