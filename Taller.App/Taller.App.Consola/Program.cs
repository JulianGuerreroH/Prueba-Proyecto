using System.Data.Common;
using System;
using Taller.App.Persistencia.Repositorios;
using Taller.App.Persistencia.AppRepositorio;
using Taller.App.Dominio.Entidades;


namespace Taller.App.Consola
{


    class Program
    {
        public static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.AppRepositorio.ContextDb()
        );
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //Console.WriteLine("Imprimiento desde la consola");
            AgregarMecanico(); //llamamos el metodo en el main, esto es lo que se hace en el front
            //ObtenerMecanicos();
            //BuscarMecanico("30");
            //EditarMecanico("23");
            //EliminarMecanico("30");

        }
        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                id = "5",
                nombre = "Charly",
                fechaNacimiento = "05/05/2010",
                nivelEstudio = "Mecanico",
                telefono = "1111",
                contrasenia = "0000",
                //rol = "jefe de operaciones"
            };

            repoMecanico.AgregarMecanico(mecanico); //Lammamos la funcion y le enviamos el mecanico creado
        }
        static void ObtenerMecanicos()
        {
            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());
            foreach (var mecanico in repoMecanico.ObtenerMecanicos())
            {
                Console.WriteLine(mecanico.id + ", Nombre:" + mecanico.nombre);
            }
        }

        static void BuscarMecanico(string id)
        {
            var mecanico = repoMecanico.BuscarMecanico(id);
            Console.WriteLine("-------");
            Console.WriteLine("Nombre: " + mecanico.nombre + "\nNivel de estudio: " + mecanico.nivelEstudio);
            Console.WriteLine("------");
        }

        static void EditarMecanico(string id)
        {
            var mecanico = new Mecanico
            {
                id = "",
                nombre = "Orlando",
                fechaNacimiento = "22/10/1992",
                nivelEstudio = "Bachiller",
                telefono = "5555",
                contrasenia = "123456"
                //rol = "jefe de operaciones"
            };
            repoMecanico.EditarMecanico(mecanico, id);
        }

        static void EliminarMecanico(string id)
        {
            repoMecanico.EliminarMecanico(id);
        }

    }
}