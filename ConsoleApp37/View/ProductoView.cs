using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


//muestra la informacion al usuario
namespace View
{
    public class ProductoView
    {
        public void MostrarLista(List<Producto> productos)
        {
            Console.WriteLine("lista de productos");
            foreach(var p in productos)
            {
                Console.WriteLine($"nombre{p.Nombre},precio{p.Precio}");
            }
        }
        public void MostrarProducto(Producto p)
        {
            Console.WriteLine($"Nombre:{p.Nombre},Precio: ${p.Precio}");
        }
        public void MostrarTotal(double total)
        {
            Console.WriteLine($"Valor total del inventario:${total}");
        }
    }
}
