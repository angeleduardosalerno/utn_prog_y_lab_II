using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto (string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;

        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            //string codigoDeBarras;
            return this.precio;
        }

        public static string MostrarProducto (Producto p)
        {
            return p.marca + p.codigoDeBarra + p.precio.ToString() ; // SI PONES + ACA HAY QUE TERMINAR LA ORACION POR QUE ESPERA UN TERMINO  
            //VER SI EL ULTIMO CAMPO TO STRING ESTA OK!
        }

        /*
        public static bool operator ==(Producto p1, Producto p2)
        {
            
        }

        public static bool operator !=(Producto p, string marca)
        {

        }
        */
    }
}
