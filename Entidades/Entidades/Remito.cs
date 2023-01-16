using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito: DocumentoComercial
    {
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, 
            string detalle, decimal total, DateTime FechaEntrega) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            this.FechaEntrega = FechaEntrega;
        }

        public DateTime FechaEntrega { get; set; }


        
    }
}
