using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public abstract class Personaje
    {

        public string nombre {get; set;}
        public int vida {get; set;}
        public int poderDeAtaque {get; set;}
        public string faccion {get; set;}
        public IArma ArmaMax {get; set;}
        public List<IArma> armas {get; set;}

        public Personaje()
        {
            armas = new List<IArma>();
        }

        public Personaje(string nombre, int vida, string faccion): this()
        {
            this.nombre = nombre;
            this.faccion = faccion;
            this.vida = vida;
            this.faccion = faccion;
            this.poderDeAtaque = 0;
        }

        public IArma perderArmaMax()
        {
            armas.Remove(ArmaMax);
            return this.ArmaMax;
        }

        public void actualizarValores()
        {
            if(armas.Count() == 0)
            {
                ArmaMax = null;
            }
            else
            {
                ArmaMax = armas.First(x => x.puntosDeAtaquePara(this) == armas.Max(y => y.puntosDeAtaquePara(this)));
            }
            poderDeAtaque = poderDeAtqTotal();
        }

        public virtual int poderDeAtqTotal()
        {
            return poderDeAtaque = armas.Sum(x => x.puntosDeAtaquePara(this));
        }

        public void alzarArma(IArma arma)
        {
            armas.Add(arma);
            actualizarValores();
        }

        public bool maxPower(Personaje personaje) => this.poderDeAtaque > personaje.poderDeAtaque;

        public bool diferenteFaccion(Personaje personaje) => this.faccion != personaje.faccion;

        public abstract int pDeAtqPorHoja();

    }
}