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
        public List<Personaje> personajes {get; set;}

        public Vehiculo()
        {
            this.personajes = new List<Personaje>();
        }

        public Vehiculo(string nombreM, int capacidad, double velocidad) : this()
        {
            this.nombreM = nombreM;
            this.capacidad = capacidad;
            this.velocidad = velocidad;
        }

        public bool obtenerMismaFaccion()
        {
            if(personajes.Count() == 0)
                return false;
            if(personajes.All(x => x.faccion == "Alianza Rebelde"))
                return true;
            if(personajes.All(x => x.faccion == "Imperio"))
                return true;
                
            return false;   
        }

        public int obtenerTotalArmas()
        {
            return personajes.Sum(x => x.armas.Count());
        }

        public void maxCapacidad()
        {
            if(this.personajes.Count() >= capacidad)
                throw new Exception("A superado la capacidad maxima del vehiculo");
        }

        public void subirPersonaje(Personaje personaje)
        {
            this.maxCapacidad();
            this.personajes.Add(personaje);
        }

        public void estaEnVehiculo(Personaje personaje)
        {
            if(personajes.Contains(personaje) == false)
                throw new Exception("El personaje no esta en el vehiculo");
        }

        public void bajarPersonaje(Personaje personaje)
        {
            this.estaEnVehiculo(personaje);
            personajes.Remove(personaje);
        }
    }
}