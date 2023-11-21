using Microsoft.EntityFrameworkCore;

namespace StoreApp.Model
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) :base(options)//dbcontext le gelmeyen ifade newlenmez
        {
            
        }
        //mthod geçersiz kılma
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product()
                {
                    ProductId=1,ProductName="Computer",Price=20_000
                },
                new Product()
                {
                    ProductId=2,ProductName="Keyboard",Price=2_000
                },
                new Product()
                {
                    ProductId=3,ProductName="Android Watch",Price=12_000
                },
                new Product()
                {
                    ProductId=4,ProductName="Play Station",Price= 22_500
                },
                new Product()
                {
                    ProductId=5,ProductName="Book",Price=20
                }
            );
        }
    }
}