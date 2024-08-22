using System;

namespace Jogo_RPG;

public class Elfo : Personagem
    {
       public Elfo()
        {
            Raca = Raca.Elfo;
            Forca = 8;
            Agilidade = 14;
            Inteligencia = 12;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Agilidade + (Forca / 2);
            alvo.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {dano} de dano. Vida de {alvo.Nome}: {alvo.Vida}");
        }

        public override void Defender()
        {
            int defesa = Agilidade;
            Vida += defesa / 5;
            Console.WriteLine($"{Nome} se defende, recuperando {defesa / 5} de vida. Vida atual: {Vida}");
        }
    }