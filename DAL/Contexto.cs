using AP1_P1_IsaacCoste.Models;
using Microsoft.EntityFrameworkCore;
namespace AP1_P1_IsaacCoste.DAL;
public class Contexto : DbContext
{ 
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Articulos> Articulos { get; set; }
}