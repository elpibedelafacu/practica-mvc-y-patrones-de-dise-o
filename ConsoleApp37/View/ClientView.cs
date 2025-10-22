using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    public class ClientView
    {
        public void MostrarCliente(Cliente p)
        {
            Console.WriteLine($"Nombre{p.Nombre},Id{p.Id},Gmail{p.Gmail}")
        }
        public void ListaDeClientes(List<Cliente> clientes)
        {
            Console.WriteLine("lista de clientes");
            foreach (var p in clientes)
            {
                Console.WriteLine($"Nombre{p.Nombre},Id{p.Id},Gmail{p.Gmail}");
            }
        } 
        public void ValidarCorreo(string Gmail)
        {

        }
    }
}
