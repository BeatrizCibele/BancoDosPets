using BancoDosPets.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoDosPets.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        { }

       public DbSet<Pet> Pets { get; set; }
       public DbSet<Categoria> Categorias { get; set; }
    }
}
