using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double IVA { get; set; }
        public double Margen { get; set; }


        public decimal PrecioBruto
        {
            get
            {
                return PrecioCosto * Convert.ToDecimal(1 + this.Margen);
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                return PrecioBruto * Convert.ToDecimal(1 + this.IVA);

            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(string nombre, string descripcion, decimal precioCosto, double iVA, double margen, 
            string proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            IVA = iVA;
            Margen = margen;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }
    }
}
