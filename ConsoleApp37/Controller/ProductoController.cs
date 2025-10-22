using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using View;


//Coordina la comunicacion entre el modelo y vista, el controlador no guarda datos ni los muestra 
//sino que se encarga de pedirle al modelo que haga algo y a la vista que muestre algo
namespace Controller
{
    public class ProductoController
    {
        private List<Producto> productos;
        private ProductoView vista;

        public ProductoController(ProductoView vista)//coordina entre modelo y vista
        {
            this.vista = vista;// parametro
            productos = new List<Producto>();
        }
        public void AgregarProducto(string nombre,double precio)
        {
            var producto = new Producto(nombre, precio);//crea el modelo
            productos.Add(producto);//guarda el modelo en la lista
        }
        public void EliminarProducto(string nombre)
        {
            var producto = productos.FirstOrDefault(p=>p.Nombre==nombre);
            if (producto != null)
            {
                productos.Remove(producto);
                Console.WriteLine($"producto '{nombre}'eliminado correctamente");
            }
            else
            {
                Console.WriteLine("no se ha podido eliminar el producto");
            }
        }
        public void BuscarProducto(string nombre)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre == nombre);
            if (producto != null)
            {
                vista.MostrarProducto(producto);
            }
        }
        public void MostrarProductos()
        {
            vista.MostrarLista(productos);//llama a la vista
        }
        public void MostrarTotal()
        {
            double total = productos.Sum(p => p.Precio);
            vista.MostrarTotal(total);
        }
    }
}
