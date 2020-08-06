using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Ex_Floristeria.Models
{
    class Flor: Elements
    {
        private string color;
        public Flor (string color, double precio)
        {
            this.setPrecio(precio);
            this.color = color;
            
        }
        public string COLOR
        {
            set => this.color = value;
            get => this.color;
        }

    }
}
