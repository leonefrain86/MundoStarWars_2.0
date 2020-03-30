using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public class Guerrero : Personaje
    {
        public int midicloriano {get; set;}
        
        public Guerrero(string nombre, int vida, string faccion, int midicloriano) 
            : base(nombre, vida, faccion)
        {
            this.midicloriano = midicloriano;
        }

        public void robarArmaMax(Personaje personaje)
        {
            if (maxPower(personaje) == true && diferenteFaccion(personaje) == true && personaje.armas.Count() >= 1)
            {
                this.alzarArma(personaje.perderArmaMax());
                personaje.actualizarValores();
                Console.WriteLine("¡Robado con exito! --max respect--");
            }
            else
            {
                Console.WriteLine("¡Fracaso el robo! --mision fracase--");
            }
        }

        public override int poderDeAtqTotal()
        {
            return poderDeAtaque = armas.Sum(x => x.puntosDeAtaquePara(this)) + midicloriano;
        }

        public override int pDeAtqPorHoja()
        {
            return midicloriano/2;
        }

        public void cambiarFaccion()
        {
            if(this.faccion == "Alianza Rebelde")
            {
                this.faccion = "Imperio";
            }
            else
            {
                this.faccion = "Alianza Rebelde";
            }
        
            Console.WriteLine("¡Cambio realizado con exito!");
        }
    }
}