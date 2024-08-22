using System;

namespace Jogo_RPG;

public abstract class Personagem
{
    public string Nome { get; set; }
        public Raca Raca { get; set; }
        public Classe Classe { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; } = 100;

        public abstract void Atacar(Personagem alvo);
        public abstract void Defender();
}