using System;

namespace Jogo_RPG;

public class Orc : Personagem
    {
        public Orc()
        {
            Raca = "Orc";
            Forca = 16;
            Agilidade = 6;
            Inteligencia = 6;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Forca + (Agilidade / 3);
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