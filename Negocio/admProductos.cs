using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class admProductos
    {
        List<Producto> ListaProductos = new List<Producto>();

        public List<Producto> Listar()
        {
            return ListaProductos;
        }

        public List<Producto> Listar(string Categoria)
        {
            return ListaProductos;
        }

        public List<Producto> Listar(string Categoria, string SubCategoria)
        {
            return ListaProductos;
        }

        public Producto ListarDetalle(string Nombre)
        {
            //Select Producto por Nombre
            return null;
        }
    }
}
