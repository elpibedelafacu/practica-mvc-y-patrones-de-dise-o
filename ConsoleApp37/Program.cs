using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Controller;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            var vista = new ProductoView();              // crea la vista
            var controlador = new ProductoController(vista); // crea el controlador
            while (true)
            {
                Console.WriteLine("/---MENU---");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Total del inventario");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opcion");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("nombre");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio");
                        double precio = double.Parse(Console.ReadLine());
                        controlador.AgregarProducto(nombre, precio);
                        break;
                    case "2":
                        controlador.MostrarProductos();
                        break;
                    case "3":
                        Console.WriteLine("nombre a buscar:");
                        controlador.EliminarProducto(Console.ReadLine());
                        break;
                    case "4":
                        Console.WriteLine("nombre a eliminar");
                        break;
                    case "5":
                        controlador.MostrarTotal();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("opcion invalida");
                        break;
                }
            }

            
        }
    }
}
