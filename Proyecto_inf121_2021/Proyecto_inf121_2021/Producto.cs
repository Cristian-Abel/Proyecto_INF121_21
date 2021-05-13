using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_inf121_2021
{
    class Producto
    {
        protected String cod;
        protected String nombre;
        protected int precio_costo;
        protected int precio_ganancia;
        protected int stock;
        protected int cantidad;
        protected String descripcion;
        protected String estado;
        protected String año;
        protected String tipo;
        protected String marca_productora;


        /*--------Getters and Setters------*/
        public string Cod { get => cod; set => cod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio_costo { get => precio_costo; set => precio_costo = value; }
        public int Precio_ganancia { get => precio_ganancia; set => precio_ganancia = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Año { get => año; set => año = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca_productora { get => marca_productora; set => marca_productora = value; }

        /*--------FIN  Getters and Setters------*/

        //----Constructors and Methods---------
        public Producto(String cod, string nombre, int precio_costo, int precio_ganancia, int stock, int cantidad, string estado, string año, string tipo, string marca_productora)
        {
            this.cod = cod;
            this.nombre = nombre;
            this.precio_costo = precio_costo;
            this.precio_ganancia = precio_ganancia;
            this.stock = stock;
            this.cantidad = cantidad;
            this.estado = estado;
            this.año = año;
            this.tipo = tipo;
            this.marca_productora = marca_productora;
        }
        public Producto()
        {

        }
        public void crear_producto()
        {

        }
        public void cambiar_stock()
        {

        }
        public void producto_defectuoso()
        {

        }
        public void mostrar()
        {

        }

    }
}
