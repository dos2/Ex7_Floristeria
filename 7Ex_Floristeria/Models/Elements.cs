using _7Ex_Floristeria.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Ex_Floristeria.Models
{
    abstract class Elements : Iprecio, Itype

    {
        private double precio;
        private int type;

        public Elements() { }
        public double Precio { get => precio; set => this.precio = value; }

        public int Type { get => type; set => this.type = value; }

        
    }
}
