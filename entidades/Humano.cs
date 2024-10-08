using System;

namespace Jogo_RPG;

public class Humano : Personagem
    {
       public Humano()
        {
            Raca = Raca.Humano;
            Forca = 10;
            Agilidade = 10;
            Inteligencia = 10;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Forca + (Agilidade / 2);
            alvo.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {dano} de dano. Vida de {alvo.Nome}: {alvo.Vida}");
        }

        public override void Defender()
        {
            int defesa = Inteligencia;
            Vida += defesa / 5;
            Console.WriteLine($"{Nome} se defende, recuperando {defesa / 5} de vida. Vida atual: {Vida}");
        }
    }