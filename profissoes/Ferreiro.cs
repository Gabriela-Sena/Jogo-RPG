using System;

namespace Jogo_RPG;

public class Ferreiro : IProfissao
    {
        public void Trabalhar()
        {
            Console.WriteLine("Ferreiro está trabalhando.");
        }

        public void Descansar()
        {
            Console.WriteLine("Ferreiro está descansando.");
        }
    }