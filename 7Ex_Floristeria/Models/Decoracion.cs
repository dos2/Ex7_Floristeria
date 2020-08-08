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
        public enum Material { Madera, Plastico };
        public Decoracion(string name, Material material, double precio) 
        {

            this._material = material;
            base.Precio = precio;
            base.Type = 2;
            base.Name = name;
        
        }
        public Material Material1 => _material;
        public override string ToString()
        {
            return string.Format("Nombre: {2}. Material: {0}. Precio: {1}€", _material,Precio,Name);
        }
    }
}
