using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

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
            Producto producto = new Producto();

            producto.Nombre = "Remera";
            producto.Descripcion = "Remera de algodon";
            producto.PrecioCosto = 25;
            producto.IVA = 0.21;
            producto.Margen = 0.15;
            producto.Proveedor = "Pedro";
            producto.Categoria = "Monotributista";
            producto.SubCategoria = "Nivel A";


            MessageBox.Show(producto.Nombre + " " + producto.Descripcion
                + "\nProovedor: " + producto.Proveedor + "\nCategoría: " + producto.Categoria
                + "\nSub categoría: " + producto.SubCategoria + "\n\nPrecio Bruto: " + producto.PrecioBruto
                + "\nPrecio Costo: " + producto.PrecioCosto + "\nMargen: " + producto.Margen * 100 + "%"
                + "\nIVA: " + producto.IVA * 100 + "%" + "\nPrecio Venta: " + producto.PrecioVenta);

        }

        private void bnt_CrearClienteIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo();

            clienteIndividuo.Nombre = "Juan";
            clienteIndividuo.Apellido = "Perez";
            clienteIndividuo.CUIT = "131313";
            clienteIndividuo.Email = "Juan@hotmail.com";
            clienteIndividuo.Telefono = "12346";
            clienteIndividuo.Direccion = "Calle 123";

            MessageBox.Show(clienteIndividuo.Nombre + " " + clienteIndividuo.Apellido
                + "\nCUIT: " + clienteIndividuo.CUIT + "\nMail: " + clienteIndividuo.Email
                + "\nNumero de telefono: " + clienteIndividuo.Telefono + "\nDireccion: " + clienteIndividuo.Direccion);

    }
    }
}
