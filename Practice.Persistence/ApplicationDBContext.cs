using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;

namespace Practice.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<Usuario>())
            {
                switch (item.State)
                {
                    case EntityState.Added:

                        var password = $"{item.Entity.Nombre.First()}{item.Entity.DNI}{item.Entity.Apellidos.First()}";

                        item.Entity.CreateDate = DateTime.Now;
                        item.Entity.CreateBy = "System";
                        item.Entity.Password = new PasswordHasher<Usuario>().HashPassword(null, password);
                        break;
                    case EntityState.Modified:
                        item.Entity.LastModifiedDate = DateTime.Now;
                        item.Entity.LastModifiedBy = "System";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
