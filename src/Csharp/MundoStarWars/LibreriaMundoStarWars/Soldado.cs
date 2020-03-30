using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public class Soldado : Personaje
    {
        public Soldado(string nombre, int vida, string faccion) 
            : base(nombre, vida, faccion)
        {

        }

        public override int pDeAtqPorHoja()
        {
            return 10;
        }
    }
}