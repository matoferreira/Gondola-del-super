using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Productos;

namespace Gondola
{
    public class Gondola
    {
        private List<Producto> productos = new List<Producto>();

        public void Reponer()
        {

        }
        public ReadOnlyCollection<Producto> Productos
        {
            get 
            {
                return this.productos.AsReadOnly(); 
            }
            
        }
        
    }

}
