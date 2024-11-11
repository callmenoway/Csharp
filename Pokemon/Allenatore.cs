using System;

namespace Pokemon
{
    public class Allenatore
    {
        public void faiCombattere(Pokemon[] squadra)
        {
            foreach (Pokemon pokemon in squadra)
            {
                Console.WriteLine(pokemon.Descrivi());
                Console.WriteLine(pokemon.Attacca());
                Console.WriteLine();
            }
        }

        public void battaglia(Pokemon p1, Pokemon p2)
        {
            int HP1 = 100; //HP iniziali per p1 (pokemon 1)
            int HP2 = 100; //HP iniziali per p2 (pokemon 2)

            Console.WriteLine("Inizia una battaglia tra " + p1.Descrivi() + " e " + p2.Descrivi());
            Console.WriteLine(p1.Attacca());
            Console.WriteLine(p2.Attacca());

            //controlla se ci sono dei vantaggi
            bool p1HaVantaggio = p1.Vantaggio(p2);
            bool p2HaVantaggio = p2.Vantaggio(p1);

            //ciclo della battaglia finché uno dei pokemon finisce gli HP
            while (HP1 > 0 && HP2 > 0)
            {
                //calcola i danni che p1 infligge a p2
                int dannoP1 = p1.GetLivello();
                if (p1HaVantaggio)
                {
                    dannoP1 = (int)(dannoP1 * 1.5); //+50% se p1 ha vantaggio
                }

                //calcola i danni che p2 infligge a p1
                int dannoP2 = p2.GetLivello();
                if (p2HaVantaggio)
                {
                    dannoP2 = (int)(dannoP2 * 1.5); //+50% se p2 ha vantaggio
                }

                //applica i danni
                HP2 = HP2 - dannoP1;
                HP1 = HP1 - dannoP2;

                Console.WriteLine(p1.GetNome() + " infligge " + dannoP1 + " danni a " + p2.GetNome() + ". HP di " + p2.GetNome() + ": " + Math.Max(0, HP2));
                Console.WriteLine($"{p2.GetNome()} infligge {dannoP2} danni a {p1.GetNome()}. HP di {p1.GetNome()}: {Math.Max(0, HP1)}");

                //interrompi se uno dei pokemon è a 0 HP
                if (HP1 <= 0 || HP2 <= 0)
                {
                    break;
                }
            }

            //determina il vincitore in base agli HP rimanenti
            if (HP1 > HP2)
            {
                Console.WriteLine(p1.GetNome() + " vince la battaglia con " + HP1 + "HP rimanenti!");
            }
            else if (HP2 > HP1)
            {
                Console.WriteLine(p2.GetNome() + " vince la battaglia con " + HP2 + " HP rimanenti!");
            }
            else
            {
                Console.WriteLine("La battaglia è un pareggio, entrambi i Pokémon sono esausti.");
            }

            Console.WriteLine();
        }
    }
}
