using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando objeto
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Regis";
            jogador1.idade = 36;
            jogador1.armadura = "faceshield";
            jogador1.ia = "Jarvis";

            Personagem jogador2 = new Personagem();
            jogador2.nome = "Denis";
            jogador2.idade = 33;
            jogador2.armadura = "bota";
            jogador2.ia = "Verônica";

            Console.WriteLine($"Partida: {jogador1.nome} vs {jogador2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura: {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.ia} || Jogador 2 IA: {jogador2.ia}");
        }
    }
}
