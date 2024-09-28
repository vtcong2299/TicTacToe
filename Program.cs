using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSystem gameSystem = new GameSystem();
            PlayControler playControler = new PlayControler();
            gameSystem.MenuGame();
            gameSystem.Display();
            playControler.Player();
        }
    }
}