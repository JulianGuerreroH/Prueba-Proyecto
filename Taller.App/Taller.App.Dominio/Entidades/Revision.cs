using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Revision
    {
        ///prop para un atajo en la creacion de atributos
        public string revisionId {get; set;}
        public string fechaRev { get; set; }
        public string mecanicoId { get; set; } //llave foranea
        //public Mecanico mecanico { get; set; } //vinculo referencial a traves de un objeto
    }
}