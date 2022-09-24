using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Persona
    {
        //public string id {get; set;} se quita el id para organizar la BD
        public string nombre {get; set;}
        public string telefono {get; set;}
        public string fechaNacimiento {get; set;}
        public string contrasenia {get; set;}
        //public string rol {get; set;}
    }
}