using System;
using System.Text;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            GameSystem gameSystem = new GameSystem();
            PlayControler playControler = new PlayControler();
            try
            {
                gameSystem.MenuGame();
                gameSystem.Display();
                playControler.Player();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại Main(): " + ex);
            }
        }
    }
}