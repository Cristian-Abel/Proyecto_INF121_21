using System;

namespace Proyecto_inf121_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Empleado a = new Empleado("12452562", "rene burgoa mendez", 75297113, "cajero", "masculino", "obrajes", 21, 2250);
            Cliente b = new Cliente("123455", "Paola rodriguez", 1234567, 224433);
            a.descripcion();
            Console.WriteLine("---------------------");
            b.descripcion();
            */
            ProductosAlmacen almacen = new ProductosAlmacen();
            almacen.crearProducto();

            Tienda tienda = new Tienda("Roblan", 75277833, "javier seballos", "Calle 8 de calacoto");
            tienda.crearEmpleado();
            tienda.crearCliente();
            tienda.mostrarEmpleado();
            
            
            
            Console.ReadKey();
        }

    }
}
