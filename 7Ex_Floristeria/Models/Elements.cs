using _7Ex_Floristeria.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Ex_Floristeria.Models
{
    abstract class Elements : Iprecio
    {
        private double precio;
        public enum Material { Madera, Plastico };

        public Elements() { }
        public double getPrecio()
        {
            return precio;
        }
        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
