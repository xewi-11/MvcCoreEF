using Microsoft.EntityFrameworkCore;
using MvcCoreEF.Models;

namespace MvcCoreEF.Data
{
    public class HospitalContext : DbContext
    {
        //El constructor recibira SIEMPRE LAS OPCIONES PARA ESTE CONTEXTO
        // La clase que recibe es (DbContextOptions<HospitalContext> options)
        // Estas options hay que enviarlas a la clase base/super
        // Del DBCONTEXT
        public HospitalContext
            (DbContextOptions<HospitalContext> options) : base(options)
        { }

        //DEBEMOS TENER UNA COLECION POR MODEL DICHA COLECION DEBE SER TIOPO DbSet<T>

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
