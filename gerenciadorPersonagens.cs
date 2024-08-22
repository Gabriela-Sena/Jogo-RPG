using System;

namespace Jogo_RPG;

public class GerenciadorDePersonagens
    {
        public Personagem CriarPersonagem(string nome, Raca raca, Classe classe, IProfissao profissao)
        {
            Personagem personagem = null;

            switch (raca)
            {
                case Raca.Humano:
                    personagem = new Humano { Nome = nome, Classe = classe };
                    break;
                case Raca.Elfo:
                    personagem = new Elfo { Nome = nome, Classe = classe };
                    break;
                case Raca.Anao:
                    personagem = new Anao { Nome = nome, Classe = classe };
                    break;
                case Raca.Orc:
                    personagem = new Orc { Nome = nome, Classe = classe };
                    break;
            }

            Console.WriteLine($"Personagem criado: {nome}, Raça: {raca}, Classe: {classe}");
            profissao.Trabalhar(); // Mostra a profissão do personagem
            return personagem;
        }

        public void Combater(Personagem p1, Personagem p2)
        {
            p1.Atacar(p2);
            if (p2.Vida > 0)
            {
                p2.Atacar(p1);
            }

            Console.WriteLine($"{p1.Nome} Vida: {p1.Vida}, {p2.Nome} Vida: {p2.Vida}");
        }
    }