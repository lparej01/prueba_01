using Microsoft.EntityFrameworkCore;
using Model.Domain;

namespace Model
{
    public class GrupoDbContext : DbContext
    {
        public GrupoDbContext(DbContextOptions<GrupoDbContext> options)
            : base(options)
        {

        }
    public DbSet<Album>  Album { get; set; }

    }
}