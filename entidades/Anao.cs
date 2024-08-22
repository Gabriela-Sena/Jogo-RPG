using System;

namespace Jogo_RPG;

public class Anao : Personagem
    {
        public Anao()
        {
            Raca = Raca.Anao;
            Forca = 14;
            Agilidade = 8;
            Inteligencia = 8;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Forca + (Inteligencia / 3);
            alvo.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {dano} de dano. Vida de {alvo.Nome}: {alvo.Vida}");
        }

        public override void Defender()
        {
            int defesa = Forca;
            Vida += defesa / 5;
            Console.WriteLine($"{Nome} se defende, recuperando {defesa / 5} de vida. Vida atual: {Vida}");
        }
    }