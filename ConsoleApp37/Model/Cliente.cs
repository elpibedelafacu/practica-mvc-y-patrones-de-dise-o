
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public double ID { get; set; }
        public string Gmail { get; set }

        public Cliente(string nombre,double id,string gmail)
        {
            Nombre = nombre;
            ID = id;
            Gmail = gmail;
        }
    }
}
