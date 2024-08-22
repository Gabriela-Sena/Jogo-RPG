using System;

namespace Jogo_RPG;

public class GerenciadorDePersonagens
    {
        public Personagem CriarPersonagem(string nome, string raca, string classe, IProfissao profissao)
        {
            Personagem personagem = null;

            switch (raca)
            {
                case "Humano":
                    personagem = new Humano();
                    break;
                case "Elfo":
                    personagem = new Elfo();
                    break;
                case "Anão":
                    personagem = new Anao();
                    break;
                case "Orc":
                    personagem = new Orc();
                    break;
                default:
                    throw new ArgumentException("Raça inválida.");
            }

            personagem.Nome = nome;
            personagem.Classe = classe;
            personagem.Profissao = profissao;

            return personagem;
        }

        public void Combater(Personagem p1, Personagem p2)
        {
            while (p1.Vida > 0 && p2.Vida > 0)
            {
                p1.Atacar(p2);
                if (p2.Vida > 0)
                {
                    p2.Atacar(p1);
                }
            }

            if (p1.Vida > 0)
            {
                Console.WriteLine($"{p1.Nome} venceu o combate!");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} venceu o combate!");
            }
        }
    }