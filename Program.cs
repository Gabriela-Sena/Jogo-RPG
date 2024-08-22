namespace Jogo_RPG;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDePersonagens gerenciador = new GerenciadorDePersonagens();

        // Criando personagens
        Personagem guerreiroHumano = gerenciador.CriarPersonagem("Arthas", Raca.Humano, Classe.Guerreiro, new Ferreiro());
        Personagem magoElfo = gerenciador.CriarPersonagem("Legolas", Raca.Elfo, Classe.Mago, new Alquimista());

        // Combate
        gerenciador.Combater(guerreiroHumano, magoElfo);
    }
}
