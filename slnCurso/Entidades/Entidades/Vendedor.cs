using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor: Persona
    {
        public string DNI { get; set; }

        public Vendedor(string nombre, string apellido, string email, string telefono, string direccion, string DNI) : base(nombre, apellido, email, telefono, direccion)
        {
            this.DNI = DNI;
        }
       
    }
}
