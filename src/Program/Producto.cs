using System;

namespace Productos
 {

     public class Producto
     {
         
         private string nombre;

         public string Nombre
         {
             get
             {
                 return this.nombre;
             }
             set
             {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.nombre=value;
                }
                 
             }
         }
         private string codigo;

        public string Codigo
         {
             get
             {
                 return this.codigo;
             }
             set
             {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.codigo=value;
                } 
             }
         }

         private int precio;

         public int Precio
         {
             get
             {
                 return this.precio;
             }
             set
             {
                 if (value >= 0)
                {
                    this.precio=value;
                }
             }
         }
    
        public Producto(string nombre, string codigo, int precio)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
        }
     }
 }