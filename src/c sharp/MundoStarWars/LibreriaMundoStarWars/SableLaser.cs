using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public class SableLaser : IArma
    {
        public int hojas {get; set;}

        public SableLaser(int hojas)
        {
            this.hojas = hojas;
        }

        public string miNombreEs()
        {
            return "Sable Laser";
        }

        public int puntosDeAtaquePara(Personaje personaje)
        {
            return hojas*personaje.pDeAtqPorHoja();
        }
    }
}