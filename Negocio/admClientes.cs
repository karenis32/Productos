using Entidades.Entidades;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class admClientes
    {
        List<ClienteIndividuo> clienteIndividuos = new List<ClienteIndividuo>();
        List<Empresa> ListaEmpresas = new List<Empresa>();

        public List<ClienteIndividuo> ListarClienteIndividuo()
        {
            return clienteIndividuos;
        }

        public ClienteIndividuo ListarClienteIndividuo(string CUIT)
        {
            //Select ClienteIndividuo por CUIT
            return null;
        }

        public List<Empresa> ListarClienteEmpresa()
        {
            return ListaEmpresas;
        }

        public Empresa ListarClienteEmpresa(string CUIT)
        {
            //Select Empresa por CUIT
            return null;
        }
    }
}
