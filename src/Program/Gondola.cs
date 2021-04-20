using System;
using System.Collections.Generic;
using Productos;

namespace Gondola
{
    public class Gondola
    {
        private List<Producto> productos = new List<Producto>();

        public void Reponer()
        {
            
        }
        public List<Producto> Productos
        {
            get 
            {
                IList<Producto> roProductos = productos.AsReadOnly();
                return this.roProductos; 
            }
            
        }
        
    }

}
