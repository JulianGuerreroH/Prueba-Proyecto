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
            //AgregarMecanico(); //llamamos el metodo en el main, esto es lo que se hace en el front
            //ObtenerMecanicos();
            BuscarMecanico();
            //EditarMecanico();
            //EliminarMecanico();
        
        }
        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                id = "23",
                nombre = "Orlando",
                fechaNacimiento = "10",
                nivelEstudio = "Bachiller",
                telefono = "22",
                contrasenia = "123",
                //rol = "jefe de operaciones"
            };

            repoMecanico.AgregarMecanico(mecanico); //Lammamos la funcion y le enviamos el mecanico creado
        }

        static void ObtenerMecanicos(){
            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());
            foreach (var mecanico in repoMecanico.ObtenerMecanicos()){
                Console.WriteLine(mecanico.nombre.ToString());
            }
        }

        static void BuscarMecanico(){
            Console.WriteLine(repoMecanico.BuscarMecanico("23"));
        }

        static void EditarMecanico(){
            var mecanico = new Mecanico
            {
                id = "",
                nombre = "Pablito",
                fechaNacimiento = "50",
                nivelEstudio = "Tecnico",
                telefono = "122",
                contrasenia = "783",
                //rol = "jefe de operaciones"
            };
            repoMecanico.EditarMecanico(mecanico);
        }

        static void EliminarMecanico(){
            Console.WriteLine(repoMecanico.BuscarMecanico("23"));
        }
    }
}