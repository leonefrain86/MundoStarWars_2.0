using System;
using System.Collections.Generic;
using System.Linq;

namespace LibreriaMundoStarWars
{
    public class Vehiculo
    {
        public string nombreM {get; set;}
        public int capacidad {get; set;}
        public double velocidad {get; set;}
        public List<Soldado> soldados {get; set;}
        public List<Guerrero> guerreros {get; set;}
        // public bool mismaFaccion {get; set;}
        // public int totalArmas {get; set;} 

        public Vehiculo()
        {
            this.soldados = new List<Soldado>();
            this.guerreros = new List<Guerrero>();
        }

        public Vehiculo(string nombreM, int capacidad, double velocidad) : this()
        {
            this.nombreM = nombreM;
            this.capacidad = capacidad;
            this.velocidad = velocidad;
            // this.totalArmas = 0;
            // this.mismaFaccion = false;
        }

        private bool obtenerMismaFaccion()
        {
            if(soldados.Count() + guerreros.Count() <= 0)
                return false;
            if(soldados.All(x => x.faccion == "Alianza Rebelde") && guerreros.All(x => x.faccion == "Alianza Rebelde"))
                return true;
            if(soldados.All(x => x.faccion == "Imperio") && guerreros.All(x => x.faccion == "Imperio"))
                return true;
                
            return false;   
        }

        private int obtenerTotalArmas()
        {
            return soldados.Sum(x => x.armas.Count()) + guerreros.Sum(x => x.armas.Count());
        }

        private void maxCapacidad()
        {
            if((soldados.Count() + guerreros.Count() + 1) > capacidad)
                throw new Exception("A superado la capacidad maxima del vehiculo");
        }

        public void subirSoldado(Soldado soldado)
        {
            maxCapacidad();
            this.soldados.Add(soldado);
            // this.totalArmas = obtenerTotalArmas();
            // this.mismaFaccion = obtenerMismaFaccion();
        }
        public void subirGuerrero(Guerrero guerrero)
        {
            maxCapacidad();
            this.guerreros.Add(guerrero);
            // this.totalArmas = obtenerTotalArmas();
            // this.mismaFaccion = obtenerMismaFaccion();
        }

        public void mostrarPersonajes()
        {
            int aux = 1;
            foreach (var soldado in soldados)
            {
                Console.WriteLine($"{aux++} tipo:{soldado.ToString()} nombre:{soldado.nombre} vida:{soldado.vida} faccion: {soldado.faccion} armas: {soldado.armas.Count()} armaMax: {soldado.ArmaMax.miNombreEs()} pAtqOtorga: {soldado.ArmaMax.puntosDeAtaquePara(soldado)}"); 
            }
            foreach (var guerrero in guerreros)
            {
                Console.WriteLine($"{aux++} tipo:{guerrero.ToString()} nombre:{guerrero.nombre} vida:{guerrero.vida} faccion:{guerrero.faccion} midicloriano:{guerrero.midicloriano} armas: {guerrero.armas.Count()} armaMax: {guerrero.ArmaMax.miNombreEs()} pAtqOtorga: {guerrero.ArmaMax.puntosDeAtaquePara(guerrero)}"); 
            }
        }

        public void bajarPersonajes()
        {
            int aux;
            do
            {
                mostrarPersonajes();
                Console.WriteLine("Elija el personaje que va a bajar: ");
                aux = Convert.ToInt32(Console.ReadLine());
                if (aux > 0 && aux <= (soldados.Count() + guerreros.Count()))
                {
                    if (aux <= soldados.Count())
                    {
                        soldados.Remove(soldados[aux-1]);
                        Console.WriteLine("¡Se bajo exitosamente al soldado!");
                    }
                    else
                    {
                        guerreros.Remove(guerreros[aux-(soldados.Count()+1)]);
                        Console.WriteLine("¡Se bajo exitosamente al guerrero!");
                    }
                }
                else
                {
                    Console.WriteLine("El personaje no esta en el vehiculo");
                }
                Console.Write("Quiere continuar s/n: "); 
            } while (Console.ReadLine() == "s"); 
        }

        public void Informe()
        {
            Console.WriteLine($"modelo: {nombreM}");
            Console.WriteLine($"capacidad: {capacidad}");
            Console.WriteLine($"personajes: {soldados.Count() + guerreros.Count()}");
            Console.WriteLine("Personajes:");
            mostrarPersonajes();
            Console.WriteLine($"misma faccion: {obtenerMismaFaccion()}");
            Console.WriteLine($"total de armas: {obtenerTotalArmas()}");
        }

    }
}