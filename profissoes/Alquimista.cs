using System;

namespace Jogo_RPG;
public class Alquimista : IProfissao // Classes para as Profissões
    {
        public void Trabalhar()
        {
            Console.WriteLine("Alquimista está trabalhando.");
        }

        public void Descansar()
        {
            Console.WriteLine("Alquimista está descansando.");
        }
    }