using System;
using Primeiro;
using Interface;
using Enum;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjetoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Caique";
            person.Idade = 19;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Giovanna";
            person2.Idade = 18;
            person2.Estado = "MG";

            Animal animal = new Animal();

            animal.Nome = "Clebao";
            animal.nomeDono = "Caique";
            animal.especie = "Porquinho da India";

            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Morfeu;
            Pessoas pessoa3 = (Pessoas)4;

            var classe = new Classe();
            var classe2 = new Segundo.Classe();
            Console.WriteLine("Olá Mundo!");
        }
    }
}
