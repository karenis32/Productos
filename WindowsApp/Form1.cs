using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto("Ropa", "Remera de algodon", 25, 0.21, 0.15, "Pedro", "Monotributista", "Nivel A");

            MessageBox.Show(producto.Nombre + "\nDescripcion: " + producto.Descripcion
                + "\nProovedor: " + producto.Proveedor + "\nCategoría: " + producto.Categoria
                + "\nSub categoría: " + producto.SubCategoria + "\n\nPrecio Bruto: " + producto.PrecioBruto
                + "\nPrecio Costo: " + producto.PrecioCosto + "\nMargen: " + producto.Margen * 100 + "%"
                + "\nIVA: " + producto.IVA * 100 + "%" + "\nPrecio Venta: " + producto.PrecioVenta);

        }

        private void bnt_CrearClienteIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo("Juan", "Perez", "Juan@hotmail.com", "15663", "Calle 123", "64654321");

            MessageBox.Show(clienteIndividuo.Nombre + " " + clienteIndividuo.Apellido + "\nMail: " + clienteIndividuo.Email + 
                "\nNumero de telefono: " + clienteIndividuo.Telefono + "\nDireccion: " + clienteIndividuo.Direccion + "\nCUIT: " + clienteIndividuo.CUIT);

    }


        private void btn_Factura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura("6546", DateTime.Now, "Sofia", "Calle 456", "Responsable inscripto",
                "Pagado", "Articulos de limpieza", 40, "A");

            MessageBox.Show("Tipo de Factura: " + factura.Tipo + "\nNumero: " + factura.Numero + "\nFecha: " + factura.Fecha +
                "\nCliente: " + factura.Cliente + "\nDireccion: " + factura.Direccion + "\nCondicion IVA: " + factura.CondicionIVA +
                "\nCondicion Venta: " + factura.CondicionVenta + "\nDetalle: " + factura.Detalle + "\nTotal: $" + factura.Total);
        }


        private void btn_Remito_Click(object sender, EventArgs e)
        {
            Remito remito = new Remito("54654", DateTime.Now, "Julia", "Calle 466", "Responsable inscripto",
                "Entregado", "Articulos de construccion", 2560, DateTime.Now);

            MessageBox.Show("Numero: " + remito.Numero + "\nFecha: " + remito.Fecha + "\nCliente: " + remito.Cliente +
                "\nDireccion: " + remito.Direccion + "\nCondicion IVA: " + remito.CondicionIVA + "\nCondicion Venta: " +
                remito.CondicionVenta + "\nDetalle: " + remito.Detalle  + "\nTotal: $" + remito.Total + "\nFecha de entrega: " + remito.FechaEntrega);
        }

        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor("Leandro", "Delfabro", "leandro@hotmail.com", "465656", "Calle 465", "148799");

            MessageBox.Show("Nombre: " + vendedor.Nombre + " " + vendedor.Apellido + "\nDNI: " + vendedor.DNI + "\nEmail: " +
                vendedor.Email + "\nTelefono: " + vendedor.Telefono + "\nDireccion: " + vendedor.Direccion);
        }

        private void btn_Empresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa("Colchones SA", "64546498746", "465321", "colchones@hotmail.com", "5465432", "Calle 123");

            MessageBox.Show("Nombre Empresa: " + empresa.Nombre + "\nCUIT: " + empresa.CUIT + "\nContacto: " + empresa.Contacto +
                "\nEmail: " + empresa.Email + "\nTelefono: " + empresa.Telefono + "\nDireccion: " + empresa.Direccion);
        }
    }
}
