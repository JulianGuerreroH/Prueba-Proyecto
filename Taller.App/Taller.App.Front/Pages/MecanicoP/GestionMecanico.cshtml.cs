using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Persistencia.Repositorios;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {
        public static RepositorioMecanico repoMecanico = new RepositorioMecanico(
        new Persistencia.AppRepositorio.ContextDb()
        );

        public static RepositorioRevision repoRevision = new RepositorioRevision(
        new Persistencia.AppRepositorio.ContextDb()
        );

        public List<Mecanico> ListaMecanicos = new List<Mecanico>(); //Iniciacion y creacion de una nueva lista

        public void OnGet()
        {
            this.ObtenerMecanicos();
        }

        public void OnPostAdd(Mecanico mec)
        {
            try
            {
                Console.WriteLine("Agrego: " + mec.nombre);
                repoMecanico.AgregarMecanico(mec);
                this.ObtenerMecanicos();
            }
            catch (System.Exception)
            {
                throw;
            }

        }  ///colocar luego del OnPostXxx un identidicador camelcase
        public void OnPostDelete(string id)
        {
            repoMecanico.EliminarMecanico(id);
            this.ObtenerMecanicos();
        }
        public void OnPostAddRevision(Revision rev)
        {
            try
            {
                //var mecanico = repoMecanico.BuscarMecanico(rev.mecanicoId);
                //rev.mecanico = mecanico;
                repoRevision.AgregarRevision(rev);
                this.ObtenerMecanicos();
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        private void ObtenerMecanicos() // con este metodo llenamos la lista creada inicialmente
        {
            foreach (var mecanico in repoMecanico.ObtenerMecanicos())
            {
                this.ListaMecanicos.Add(
                    new Mecanico()
                    {
                        mecanicoId = mecanico.mecanicoId,
                        nombre = mecanico.nombre,
                        telefono = mecanico.telefono,
                        nivelEstudio = mecanico.nivelEstudio,
                        fechaNacimiento = mecanico.fechaNacimiento,
                        contrasenia = mecanico.contrasenia

                    }
                );
            }
        }


        /*
                public class Mecanics
                {
                    public string id { get; set; }
                    public string nombre { get; set; }
                    public string telefono { get; set; }
                    public string nivelEstudio { get; set; }

                    public Mecanics()
                    {

                    }
                }*/
    }
}
