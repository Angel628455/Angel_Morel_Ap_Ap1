using Microsoft.EntityFrameworkCore;
using Angel_Morel_Ap_Ap1.Models;

namespace Angel_Morel_Ap_Ap1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
              : base(options) { }

        public DbSet<Aporte> Aporte { get; set; }
    }
}