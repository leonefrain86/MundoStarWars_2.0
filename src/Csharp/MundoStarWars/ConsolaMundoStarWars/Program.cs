using System;
using LibreriaMundoStarWars;
using System.Collections.Generic;
using System.Linq;

namespace ConsolaMundoStarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de soldados y guerreros
            Soldado unSoldado = new Soldado("efrain", 120, "Imperio");
            Soldado otroSoldado = new Soldado("efrain2", 120, "Imperio");
            Guerrero unGuerrero = new Guerrero("lyon1", 140, "Alianza Rebelde", 100);
            Guerrero otroGuerrero = new Guerrero("lyon2", 200, "Alianza Rebelde", 100);

            //Creacion de Armas
            Blaster unBlaster = new Blaster(300);
            SableLaser unSableLaser= new SableLaser(2);
            Blaster otroBlaster = new Blaster(150);
            SableLaser otroSableLaser= new SableLaser(1);

//---------------------------------------------------------------------------------------------------------------------------------------------
            //ALZAR ARMAS

            //Guerreros
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Informe de guerreros antes de alzar armas: ");
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            informePersonaje(unGuerrero);
            Console.WriteLine("-------------------------");
            informePersonaje(otroGuerrero);
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //Los guerreros alzan armas
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Informe de guerreros despues de alzar armas: ");
            Console.WriteLine();
            unGuerrero.alzarArma(unBlaster);
            unGuerrero.alzarArma(unSableLaser);
            unGuerrero.alzarArma(otroBlaster);
            unGuerrero.alzarArma(otroSableLaser);

            otroGuerrero.alzarArma(unBlaster);
            otroGuerrero.alzarArma(unSableLaser);
            otroGuerrero.alzarArma(otroSableLaser);
            Console.WriteLine("-------------------------");
            informePersonaje(unGuerrero);
            Console.WriteLine("-------------------------");
            informePersonaje(otroGuerrero);
            Console.WriteLine();

            //Soldados
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Informe de soldados antes de alzar armas: ");
            Console.WriteLine();
            
            informePersonaje(unSoldado);
            Console.WriteLine("-----------------------");
            informePersonaje(otroSoldado);
            Console.WriteLine();

            //Los soldados alzan armas
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Informe de soldados despues de alzar armas: ");
            Console.WriteLine();
            unSoldado.alzarArma(unBlaster);
            unSoldado.alzarArma(unSableLaser);
            unSoldado.alzarArma(otroBlaster);
            unSoldado.alzarArma(otroSableLaser);

            otroSoldado.alzarArma(unBlaster);
            otroSoldado.alzarArma(unSableLaser);
            otroSoldado.alzarArma(otroSableLaser);

            Console.WriteLine("------------------------");
            informePersonaje(unSoldado);
            Console.WriteLine("------------------------");
            informePersonaje(otroSoldado);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
//-----------------------------------------------------------------------------------------------------------------------------------
            //CAMBIO DE FACCION DE GUERRERO
            Console.WriteLine("Antes de cambiar de faccion: ");
            Console.WriteLine("-------------------------");
            informePersonaje(unGuerrero);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            unGuerrero.cambiarFaccion();
            Console.WriteLine();
            Console.WriteLine("Despues de cambiar de faccion: ");
            Console.WriteLine("-------------------------");
            informePersonaje(unGuerrero);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
//-----------------------------------------------------------------------------------------------------------------------------------
            //ROBO DE ARMA MAS PODEROSA
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Antes de robo: ");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            informePersonaje(unGuerrero);
            Console.WriteLine("--------------------------");
            informePersonaje(otroGuerrero);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            unGuerrero.robarArmaMax(otroGuerrero);
            unGuerrero.robarArmaMax(otroGuerrero);
            unGuerrero.robarArmaMax(otroGuerrero);
            Console.WriteLine();
            Console.WriteLine("Despues de robo:");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            informePersonaje(unGuerrero);
            Console.WriteLine("--------------------------");
            informePersonaje(otroGuerrero);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
//---------------------------------------------------------------------------------------------------------------------------------------------
            //SUBIDA Y BAJADA DE PERSONAJES DEL VEHICULO

            Console.WriteLine("Vehiculo creado: ");
            Vehiculo unVehiculo = new Vehiculo("HZX", 3, 1500);
            Console.WriteLine();
            informeVehiculo(unVehiculo);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Luego de la subida de dos personajes: ");
            unVehiculo.subirPersonaje(unGuerrero);
            unVehiculo.subirPersonaje(unSoldado);
            informeVehiculo(unVehiculo);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Bajar personajes:");
            unVehiculo.bajarPersonaje(unSoldado);
            unVehiculo.bajarPersonaje(unGuerrero);
            Console.WriteLine();
            Console.WriteLine("Luego de la bajada de personajes:");
            informeVehiculo(unVehiculo);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");

            Soldado soldadoDesconocido = new Soldado("desconcido", 120, "Imperio");

            // Console.WriteLine("Luego intenar bajar a un personaje que no esta en el vehiculo: ");
            // unVehiculo.bajarPersonaje(soldadoDesconocido);

            // Console.WriteLine("Luego intenar subir a un personajes que superan la capacidad: ");
            // unVehiculo.subirPersonaje(unGuerrero);
            // unVehiculo.subirPersonaje(unSoldado);
            // unVehiculo.subirPersonaje(unGuerrero);
            // unVehiculo.subirPersonaje(unSoldado);

            
            
            Console.WriteLine();
        }
        static void informePersonaje(Personaje personaje)
        {
            Console.WriteLine($"nombre: {personaje.nombre}");
            Console.WriteLine($"vida: {personaje.vida}");
            Console.WriteLine($"poder de Ataque: {personaje.poderDeAtaque}");
            Console.WriteLine($"faccion: {personaje.faccion}");
            Console.WriteLine($"armas: {personaje.armas.Count()}");
            if(personaje.ArmaMax != null)
            {
                Console.WriteLine($"armaMax: {personaje.ArmaMax.puntosDeAtaquePara(personaje)} nombre: {personaje.ArmaMax.miNombreEs()}");
            }
            else
            {
                Console.WriteLine($"armaMax: null nombre: null");
            }
        }
        static void informeVehiculo(Vehiculo vehiculo)
        {
            Console.WriteLine($"modelo: {vehiculo.nombreM}");
            Console.WriteLine($"capacidad: {vehiculo.capacidad}");
            Console.WriteLine($"personajes: {vehiculo.personajes.Count()}");
            Console.WriteLine($"misma faccion: {vehiculo.obtenerMismaFaccion()}");
            Console.WriteLine($"total de armas: {vehiculo.obtenerTotalArmas()}");
        }
    }
}
