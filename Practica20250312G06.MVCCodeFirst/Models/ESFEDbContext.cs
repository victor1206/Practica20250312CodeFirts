using Microsoft.EntityFrameworkCore;

namespace Practica20250312G06.MVCCodeFirst.Models
{
    public class ESFEDbContext : DbContext
    {
        public ESFEDbContext(DbContextOptions<ESFEDbContext> options) : base(options) { }
        public DbSet<Proveedor> Proveedores { get; set; }

    }
}
