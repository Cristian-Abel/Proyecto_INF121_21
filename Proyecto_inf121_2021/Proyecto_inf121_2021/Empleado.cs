using System;
using System.Collections.Generic;


namespace Proyecto_inf121_2021
{
    class Empleado : Persona
    {
        private String cargo, sexo, direccion;
        private int edad, sueldo;

        //---------getters and setters--------------------------
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        //---------Constructores and metodos--------------------------
        public Empleado(String ci, String nombre, int celular, string cargo, string sexo, string direccion, int edad, int sueldo): base(ci,nombre,celular)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.direccion = direccion;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public Empleado():base()
        {
            
        }
        public void leer()
        {
            base.leer();
            Console.WriteLine("sexo: ");
            sexo = Console.ReadLine();
            Console.WriteLine("direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("edad: " );
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("cargo: ");
            cargo = Console.ReadLine();
            Console.WriteLine("sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
        }
        

        public void descripcion()
        {
            base.descripcion();
            Console.WriteLine("sexo: "+sexo);
            Console.WriteLine("direccion: " + direccion);
            Console.WriteLine("edad: " + edad);
            Console.WriteLine("cargo: " + cargo);
            Console.WriteLine("sueldo: " + sueldo);
        }
    }
}
