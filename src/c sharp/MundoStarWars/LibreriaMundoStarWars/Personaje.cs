using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public class Personaje
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

        public bool maxPower(Personaje personaje)
        {
            if (this.poderDeAtaque > personaje.poderDeAtaque)
            {
                return true;
            }
            return false;
        }

        public bool diferenteFaccion(Personaje personaje)
        {
            if (this.faccion != personaje.faccion)
            {
                return true;
            }
            return false;
        }

        public void mostrarArmas()
        {
            foreach (var arma in armas)
            {
                Console.WriteLine($"poder otorgado: {arma.puntosDeAtaquePara(this)} nombre: {arma.miNombreEs()}");
            }
        }

        public virtual int pDeAtqPorHoja()
        {
            return 10;
        }

        public void informePersonaje()
        {
            Console.WriteLine($"nombre: {nombre}");
            Console.WriteLine($"vida: {vida}");
            Console.WriteLine($"poder de Ataque: {poderDeAtaque}");
            Console.WriteLine($"faccion: {faccion}");
            Console.WriteLine($"armas: {armas.Count()}");
            Console.WriteLine("ARMAS");
            this.mostrarArmas();
            if(ArmaMax != null)
            {
                Console.WriteLine($"armaMax: {ArmaMax.puntosDeAtaquePara(this)} nombre: {ArmaMax.miNombreEs()}");
            }
            else
            {
                Console.WriteLine($"armaMax: null nombre: null");
            }
              
        }
    }
}