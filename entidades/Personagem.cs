using System;

namespace Jogo_RPG;

public abstract class Personagem // Classe Abstrata Personagem
{
    public string Nome { get; set; }
        public Raca Raca { get; set; }  // Raça do personagem (usando o enum Raca)
        public Classe Classe { get; set; } // Classe do personagem (usando o enum Classe)

         // Atributos que afetam o desempenho do personagem
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; } = 100;

     // Métodos abstratos para ataque e defesa - devem ser implementados pelas classes derivadas
        public abstract void Atacar(Personagem alvo);
        public abstract void Defender();
}