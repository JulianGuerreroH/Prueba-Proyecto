using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Taller.App.Persistencia.Repositorios;

namespace Taller.App.Persistencia.AppRepositorio
{
    //https://www.entityframeworktutorial.net/efcore/entity-framework-core-dbcontext.aspx
    public class ContextDb : DbContext
    {
        public virtual DbSet<Mecanico> Mecanicos { get; set; }
        public virtual DbSet<Revision> Revisiones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //metodo para conectarnos con la base de datos
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=tcp:server-tallertic-eq.database.windows.net,1433;Initial Catalog=bd_tallertic;Persist Security Info=False;User ID=adminticeq;Password=contra-Admineq0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Oucrrió un error en OnConfiguring");
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Revision>()
            //.HasOne(b => b.mecanico)
            //.WithOne(i => i.revision)
            //.HasForeignKey<Revision>(b => b.mecanicoId);
        }
    }
}