using Estudo_MVC_ASP.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudo_MVC_ASP.NET.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contato { get; set; }
    }
}
