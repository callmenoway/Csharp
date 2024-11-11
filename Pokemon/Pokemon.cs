using System;
using System.Collections.Generic;

namespace Pokemon
{
    public abstract class Pokemon
    {
        protected string nome; //nome pokemon
        protected int livello; //livello pokemon
        protected string tipo; //tipo pokemon

        //setter iniziale pokemon
        public Pokemon(string nome, int livello, string tipo)
        {
            this.nome = nome;
            this.livello = livello;
            this.tipo = tipo;
        }

        //getter per accedere alle variabili pokemon
        public string GetNome()
        {
            return nome;
        }

        public int GetLivello()
        {
            return livello;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public abstract string Attacca();

        public abstract string Descrivi();

        public abstract void evolvi();

        private static readonly Dictionary<string, string> debolezze = new Dictionary<string, string>
        {
            {"Fuoco","Erba" },
            {"Acqua","Fuoco" },
            {"Erba","Acqua" }
        };

        //soluzione booleana per il vantaggio del 50% di danno in più
        public bool Vantaggio(Pokemon avversario)
        {
            return debolezze.ContainsKey(this.tipo) && debolezze[this.tipo] == avversario.GetTipo();
        }

    }

    //CHARMANDER
    public class Charmander : Pokemon
    {
        public Charmander(int livello) : base("Charmander", livello, "Fuoco") { }

        public override string Attacca()
        {
            return "Charmander usa Braciere!";
        }

        public override string Descrivi()
        {
            return "Sono un Pokémon di nome " + nome + ", livello " + livello;
        }

        public override void evolvi()
        {
            nome = "Charmeleon";
            livello = livello + 10;
            Console.WriteLine("Charmander evolve in " + nome + " e aumenta di 10 livelli.");
        }
    }

    //SQUIRTLE
    public class Squirtle : Pokemon
    {
        public Squirtle(int livello) : base("Squirtle", livello, "Acqua") { }

        public override string Attacca()
        {
            return "Squirtle usa Pistolacqua!";
        }

        public override string Descrivi()
        {
            return "Sono un Pokémon di nome " + nome + ", livello " + livello;
        }

        public override void evolvi()
        {
            nome = "Wartortle";
            livello = livello + 10;
            Console.WriteLine("Squirtle evolve in " + nome + " e aumenta di 10 livelli.");
        }
    }

    //BULBASAUR
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(int livello) : base("Bulbasaur", livello, "Erba") { }

        public override string Attacca()
        {
            return "Bulbasaur usa Frustata!";
        }

        public override string Descrivi()
        {
            return "Sono un Pokémon di nome " + nome + ", livello " + livello;
        }

        public override void evolvi()
        {
            nome = "Ivysaur";
            livello = livello + 10;
            Console.WriteLine("Bulbasaur evolve in " + nome + " e aumenta di 10 livelli.");
        }
    }
}
