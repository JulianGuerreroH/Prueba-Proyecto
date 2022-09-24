using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia.AppRepositorio;

namespace Taller.App.Persistencia.Repositorios
{
    public class RepositorioRevision
    {
        private readonly ContextDb dbContext;
        public RepositorioRevision(ContextDb dbContext)
        {
            this.dbContext = dbContext; //el this. hace referencia al db context de la fila 13
        }

        public Revision AgregarRevision(Revision rev)
        {
            var revisionNueva = this.dbContext.Revisiones.Add(rev);
            this.dbContext.SaveChanges();
            return revisionNueva.Entity; //para convertirlo en entidad
        }
    }
}