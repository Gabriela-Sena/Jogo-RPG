using System;

namespace Jogo_RPG;

public class Anao : Personagem
    {
        public Anao()
        {
            Raca = Raca.Orc; //ver por que está dando conflito?
            Forca = 14;
            Agilidade = 8;
            Inteligencia = 8;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Forca + (Agilidade / 2);
            alvo.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {dano} de dano. Vida de {alvo.Nome}: {alvo.Vida}");
        }

        public override void Defender()
        {
            int defesa = Forca + (Inteligencia / 2);
            Vida += defesa / 4;
            Console.WriteLine($"{Nome} se defende, recuperando {defesa / 4} de vida. Vida atual: {Vida}");
        }
    }