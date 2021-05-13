using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_inf121_2021
{
    class Tienda
    {
        private String  nombre;
        private int telefono;
        private String dueño;
        private String direccion;
        private Empleado[] e = new Empleado[100];
        private int nroE;
        private Cliente[] c = new Cliente[100];
        private int nroC;

        //----------------Getters and Setters----------------
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Dueño { get => dueño; set => dueño = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal Empleado[] E { get => e; set => e = value; }
        public int NroE { get => nroE; set => nroE = value; }
        public int NroC { get => nroC; set => nroC = value; }

        public Tienda(string nombre, int telefono, string dueño, string direccion)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.dueño = dueño;
            this.direccion = direccion;
            nroE = 0;
            nroC = 0;
        }
        public void crearEmpleado()
        {
            NroE++;
            E[NroE] = new Empleado();
            E[NroE].leer();
        }
        public void mostrarEmpleado()
        {
            for(int i = 1; i <= NroE; i++)
            {
                E[i].descripcion();
            }
        }
        public void crearCliente()
        {

        }
        public void mostrarCliente()
        {

        }
        public void buscarEmpleado(String nombre)
        {

        }
        public void buscarCliente(String nombre)
        {

        }
    }
}
