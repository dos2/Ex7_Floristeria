using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Ex_Floristeria.Models
{
    class floristeria
    {
        private string nombre;
        public List<Elements> Almacen = new List<Elements>();
        private int nArbol = 0;
        //private List<Flor> listFlor;
        private int nFlor = 0;
        //private List<Decoracion> listDecoracion;
        private int nDecoracion = 0;


        public floristeria(string nombre)
        {
            this.nombre = nombre;
        }

        public string NOMBRE
        {
            set => this.nombre = value;
            get => this.nombre;
        }



        public void addArbol(double altura, double precio)
        {
            Almacen.Add(new Arbol(altura, precio));
            nArbol++;
        }

        public void addFlor(string color, double precio)
        {
            Almacen.Add(new Flor(color, precio));
            nFlor++;
        }

        public void addDecoracion(Decoracion.Material material, double precio)
        {
            Almacen.Add(new Decoracion(material, precio));
            nDecoracion++;
        }
    }
}
