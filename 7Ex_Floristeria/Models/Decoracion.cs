using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Ex_Floristeria.Models
{
    class Decoracion : Elements
    {
        private readonly Material _material;
        public Decoracion(Material material, double precio) 
        {

            this._material = material;
            base.setPrecio(precio);
        
        }
        public Material getMaterial()
        {
            return _material;
        }
    }
}
