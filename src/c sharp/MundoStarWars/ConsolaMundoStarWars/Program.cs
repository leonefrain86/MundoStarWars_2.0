using System;
using LibreriaMundoStarWars;

namespace ConsolaMundoStarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de soldados y guerreros
            Soldado unSoldado = new Soldado("efrain", 120, "Imperio");
            Soldado otroSoldado = new Soldado("efrain2", 120, "Imperio");
            Guerrero unGuerrero = new Guerrero("lyon1", 140, "Alianza rebelde", 100);
            Guerrero otroGuerrero = new Guerrero("lyon2", 200, "Alianza rebelde", 100);

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
            unGuerrero.informePersonaje();
            Console.WriteLine("-------------------------");
            otroGuerrero.informePersonaje();
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
            unGuerrero.informePersonaje();
            Console.WriteLine("-------------------------");
            otroGuerrero.informePersonaje();
            Console.WriteLine();

            //Soldados
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Informe de soldados antes de alzar armas: ");
            Console.WriteLine();
            
            unSoldado.informePersonaje();
            Console.WriteLine("-----------------------");
            otroSoldado.informePersonaje();
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
            unSoldado.informePersonaje();
            Console.WriteLine("------------------------");
            otroSoldado.informePersonaje();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
//-----------------------------------------------------------------------------------------------------------------------------------
            //CAMBIO DE FACCION DE GUERRERO
            Console.WriteLine("Antes de cambiar de faccion: ");
            Console.WriteLine("-------------------------");
            unGuerrero.informePersonaje();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            unGuerrero.cambiarFaccion();
            Console.WriteLine();
            Console.WriteLine("Despues de cambiar de faccion: ");
            Console.WriteLine("-------------------------");
            unGuerrero.informePersonaje();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
//-----------------------------------------------------------------------------------------------------------------------------------
            //ROBO DE ARMA MAS PODEROSA
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Antes de robo: ");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            unGuerrero.informePersonaje();
            Console.WriteLine("--------------------------");
            otroGuerrero.informePersonaje();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Informe de robos:");
            Console.WriteLine();
            unGuerrero.robarArmaMax(otroGuerrero);
            unGuerrero.robarArmaMax(otroGuerrero);
            unGuerrero.robarArmaMax(otroGuerrero);
            Console.WriteLine();
            Console.WriteLine("Despues de robo:");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            unGuerrero.informePersonaje();
            Console.WriteLine("--------------------------");
            otroGuerrero.informePersonaje();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
//---------------------------------------------------------------------------------------------------------------------------------------------
            //SUBIDA Y BAJADA DE PERSONAJES DEL VEHICULO

            Console.WriteLine("Vehiculo creado: ");
            Vehiculo unVehiculo = new Vehiculo("HZX", 3, 1500);
            Console.WriteLine();
            unVehiculo.Informe();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Luego de la subida de dos personajes: ");
            unVehiculo.subirGuerrero(unGuerrero);
            unVehiculo.subirSoldado(unSoldado);
            unVehiculo.Informe();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Bajar personajes:");
            unVehiculo.bajarPersonajes();
            Console.WriteLine();
            Console.WriteLine("Luego de la bajada de personajes:");
            unVehiculo.Informe();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            // Console.WriteLine("Luego de la subida personajes, superando la capacidad maxima: ");
            // unVehiculo.subirGuerrero(unGuerrero);
            // unVehiculo.subirSoldado(unSoldado);
            // unVehiculo.subirGuerrero(otroGuerrero);
            // unVehiculo.subirSoldado(otroSoldado);
            // unVehiculo.Informe();
            // Console.WriteLine();
        }
    }
}
