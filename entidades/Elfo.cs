using System;

namespace Jogo_RPG;

public class Elfo : Personagem
    {
        public Elfo()
        {
            Raca = "Elfo";
            Forca = 8;
            Agilidade = 12;
            Inteligencia = 14;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = (Forca / 2) + Agilidade;
            alvo.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {dano} de dano. Vida de {alvo.Nome}: {alvo.Vida}");
        }

        public override void Defender()
        {
            int defesa = Inteligencia + Agilidade;
            Vida += defesa / 3;
            Console.WriteLine($"{Nome} se defende, recuperando {defesa / 3} de vida. Vida atual: {Vida}");
        }
    }