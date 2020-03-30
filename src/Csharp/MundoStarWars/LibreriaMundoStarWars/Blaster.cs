using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public class Blaster: IArma
    {
        public int alcance {get; set;}

        public Blaster(int alcance)
        {
            this.alcance = alcance;
        }

        public string miNombreEs()
        {
            return "Blaster";
        }

        public int puntosDeAtaquePara(Personaje personaje)
        {
            return alcance;
        }
    }
}