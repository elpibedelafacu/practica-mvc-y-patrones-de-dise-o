using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Model Producto contiene los datos y la logica 
namespace Model
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre,double precio)//constructor
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
