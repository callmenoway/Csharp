using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main()
        {
            //dichiarazione della squadra pokemon composta dai 3 pokemon
            Pokemon[] squadra = new Pokemon[]
            {
                new Charmander(6),
                new Squirtle(5),
                new Bulbasaur(7)
            };

            Allenatore allenatore = new Allenatore(); //dichiarazione allenatore
            allenatore.faiCombattere(squadra); //dichiarazione battaglie tra pokemon

            foreach (Pokemon pokemon in squadra)
            {
                pokemon.evolvi(); //evoluzione inziale dei pokemon (10 livelli)
            }

            //battaglia tra i pokemon evoluti
            Console.WriteLine("Iniziano le battaglie tra i Pokémon evoluti:");

            //charmander (charmeleon) contro squirtle (wartortle)
            allenatore.battaglia(squadra[0], squadra[1]);

            //charmander (charmeleon) contro bulbasaur (ivysaur)
            allenatore.battaglia(squadra[0], squadra[2]);

            //squirtle (wartortle) contro bulbasaur (ivysaur)
            allenatore.battaglia(squadra[1], squadra[2]);

            Console.ReadLine();
        }
    }
}