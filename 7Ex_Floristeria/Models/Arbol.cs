using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Ex_Floristeria.Models
{
    class Arbol: Elements
    {
        private double altura;

        public Arbol (double altura, double precio)
        {
            this.setPrecio(precio);
            this.altura = altura;
        }

        public double ALTURA
        {
            set => this.altura = value;
            get => this.altura;
        }
    }
}
