using System;
using System.Collections.Generic;


namespace Proyecto_inf121_2021
{
    class Cliente:Persona
    {
        private int nit;
        //----Getters and Setters---
        public int Nit { get => nit; set => nit = value; }
        //----Constructors and methods------
        public Cliente(string ci, string nombre, int celular,int nit) : base(ci, nombre, celular)
        {
            this.nit = nit;
        }
        public void descripcion()
        {
            base.descripcion();
            Console.WriteLine("nit: "+nit);
        }
        
    }
}
