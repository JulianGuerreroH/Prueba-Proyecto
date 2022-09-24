using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Mecanico: Persona
    {
        public string mecanicoId { get; set; }
        public string nivelEstudio {get; set;}
        //public Revision revision {get; set;}
    }
}