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

namespace slnLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrarAutor_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(26/08/1914);

            Autor autor =new Autor("Julio", "Cortázar", dateTime, "Calle 4645", "Ixelles", "Bélgica");

            MessageBox.Show("Nombre Autor: " + autor.Nombre + " " + autor.Apellido + "\nFecha de Nacimiento: " + dateTime +
                "\nDomicilio: " + autor.Domicilio + "\nCiudad: " + autor.Ciudad + "\nPaís: " + autor.País);
        }
    }
}
