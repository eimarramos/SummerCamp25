using ApiPaisesProyecto.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiPaisesProyecto.BaseDatos
{
    /// <summary>
    /// 2- Crear el contexto de la base de datos
    /// </summary>
    public class ContextoBaseDatos : DbContext
    {
        public DbSet<Apartamento> Apartamentos { get; set; }

        public ContextoBaseDatos(DbContextOptions<ContextoBaseDatos> options) : base(options)
        {
        }
    }
}
