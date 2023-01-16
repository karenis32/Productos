using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura: DocumentoComercial
    {public string Tipo { get; set; }

        public Factura(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, 
            string detalle, decimal total, string Tipo) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            this.Tipo= Tipo;
        }
              
    }
}
