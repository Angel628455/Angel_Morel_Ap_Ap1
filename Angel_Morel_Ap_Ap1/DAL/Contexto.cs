using Angel_Morel_Ap_Ap1.Service;
using Microsoft.EntityFrameworkCore;

namespace Angel_Morel_Ap_Ap1.Contexto
{
    public class Contexto
    {
        public DbSet<RegistroAportes> registroAportes { get; set; }
    }
}
