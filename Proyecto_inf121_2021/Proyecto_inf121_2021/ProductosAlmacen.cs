using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_inf121_2021
{
    class ProductosAlmacen
    {
        private Producto[] p;
        private int nroP;
        //------Getters and Setters-------------
        public int NroP { get => nroP; set => nroP = value; }
        internal Producto[] P { get => p; set => p = value; }
        //--------Constructors and methods-----------
        public ProductosAlmacen()
        {
            nroP = 0;
        }
        public void crearProducto()
        {

        }
        public void mostrarProducto()
        {

        }
        public void actualizarProducto(String cod)
        {
            //realizar busquedas y luego actualizar
        }
        
    }
}
