using System;

namespace Jogo_RPG;

public class GerenciadorDePersonagens
    {
        // Método para criar um novo personagem
        public Personagem CriarPersonagem(string nome, Raca raca, Classe classe, IProfissao profissao)
        {
            Personagem personagem = null;

            switch (raca) // Criação do personagem com base na raça
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

            // Exibe o tipo de profissão e cria o personagem
            Console.WriteLine($"Personagem criado: {nome}, Raça: {raca}, Classe: {classe}");
            profissao.Trabalhar(); // Mostra a profissão do personagem
            return personagem;
        }

        // Método para realizar um combate entre dois personagens   
        public void Combater(Personagem p1, Personagem p2)
        {
            p1.Atacar(p2);  // Personagem 1 ataca Personagem 2
            if (p2.Vida > 0) // Verifica se Personagem 2 ainda está vivo
            {
                p2.Atacar(p1); // Personagem 2 ataca Personagem 1
            }

            // Exibe o resultado do combate
            Console.WriteLine($"{p1.Nome} Vida: {p1.Vida}, {p2.Nome} Vida: {p2.Vida}");
        }
    }