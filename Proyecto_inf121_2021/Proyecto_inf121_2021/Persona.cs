using System;
using System.Collections.Generic;


namespace Proyecto_inf121_2021
{
    class Persona
    {
        protected String ci;
        protected String nombre;
        protected int celular;
        //---------getters and setters--------------------------
        public string Ci { get => ci; set => ci = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Celular { get => celular; set => celular = value; }
        //---------Constructores and metodos--------------------------
        public Persona(String ci,String nombre,int celular) 
        {
            this.celular = celular;
            this.nombre = nombre;
            this.ci = ci;
            
        }
        public Persona()
        {

        }
        public void leer()
        {
            Console.WriteLine("nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ci: ");
            ci = Console.ReadLine();
            Console.WriteLine("telefono: ");
            celular = int.Parse(Console.ReadLine());
        }
        public void descripcion()
        {
            Console.WriteLine("ci:"+ci);
            Console.WriteLine("nombre:" + nombre);
            Console.WriteLine("celular:" + celular);
        }
        public String obt_nombre()
        {
            return Nombre;
        }

    }
}
