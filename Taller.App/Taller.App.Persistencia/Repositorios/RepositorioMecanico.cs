using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades; // para hacer uso del dominio teniendo en cuenta la conexion L23;
using Taller.App.Persistencia.AppRepositorio;


namespace Taller.App.Persistencia.Repositorios
{
    public class RepositorioMecanico
    {
        private readonly ContextDb dbContext;
        public RepositorioMecanico(ContextDb dbContext)
        {
            this.dbContext = dbContext; //el this. hace referencia al db context de la fila 13
        }
        //empezar a crear los metodos
        //para hacer la refencia : dotnet add reference ../Taller.App.Dominio
        public Mecanico AgregarMecanico(Mecanico mec)
        {
            var mecanicoNuevo = this.dbContext.Mecanicos.Add(mec);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity; //para convertirlo en entidad
        }
    }
}