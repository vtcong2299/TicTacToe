using System;

namespace TicTacToe
{
    public class GameSystem
    {
        string LichSuChoi = @"C:\Users\admin\Documents\HocLapTrinh\LapTrinhGameUnity\CongTapCode\C#\BaiTapCodeGym\TicTacToe\LichSuChoi.csv";
        public char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static string? playerName1;
        public static string? playerName2;
        int i = 0;
        public void MenuGame()
        {
            try
            {
                Console.WriteLine("Game TicTacToe");
                Console.WriteLine("Player 1 là người đánh trước");
                Console.WriteLine("----------------------------");
                Console.Write("Nhập tên Player 1: ");
                playerName1 = Console.ReadLine();
                Console.Write("Nhập tên Player 2: ");
                playerName2 = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại MenuGame(): " + ex);
            }
        }
        public void Display()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("{0}: X, {1}: O", playerName1, playerName2);
                Console.WriteLine();
                Console.WriteLine("-------------");
                Console.WriteLine("| {0} | {1} | {2} |", board[0], board[1], board[2]);
                Console.WriteLine("|---|---|---|");
                Console.WriteLine("| {0} | {1} | {2} |", board[3], board[4], board[5]);
                Console.WriteLine("|---|---|---|");
                Console.WriteLine("| {0} | {1} | {2} |", board[6], board[7], board[8]);
                Console.WriteLine("-------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại Display(): " + ex);
            }
        }
        public void CheckWin()
        {
            GameSystem gameSystem = new GameSystem();
            try
            {
                if ((board[0] == 'X' && board[1] == 'X' && board[2] == 'X') || (board[3] == 'X' && board[4] == 'X' && board[5] == 'X') ||
                (board[6] == 'X' && board[7] == 'X' && board[8] == 'X') || (board[0] == 'X' && board[3] == 'X' && board[6] == 'X') ||
                (board[1] == 'X' && board[4] == 'X' && board[7] == 'X') || (board[2] == 'X' && board[5] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[4] == 'X' && board[8] == 'X') || (board[2] == 'X' && board[4] == 'X' && board[6] == 'X'))
                {
                    Console.WriteLine("\n{0} !!! WIN !!!\n", playerName1);
                    gameSystem.WriteLichSuChoi(playerName1);
                    gameSystem.ReadLichSuChoi();
                    Environment.Exit(0);
                }
                else if ((board[0] == 'O' && board[1] == 'O' && board[2] == 'O') || (board[3] == 'O' && board[4] == 'O' && board[5] == 'O') ||
                    (board[6] == 'O' && board[7] == 'O' && board[8] == 'O') || (board[0] == 'O' && board[3] == 'O' && board[6] == 'O') ||
                    (board[1] == 'O' && board[4] == 'O' && board[7] == 'O') || (board[2] == 'O' && board[5] == 'O' && board[8] == 'O') ||
                    (board[0] == 'O' && board[4] == 'O' && board[8] == 'O') || (board[2] == 'O' && board[4] == 'O' && board[6] == 'O'))
                {
                    Console.WriteLine("\n{0} !!! WIN !!!\n", playerName2);
                    gameSystem.WriteLichSuChoi(playerName2);
                    gameSystem.ReadLichSuChoi();
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại CheckWin(): " + ex);
            }
        }
        public void ReadLichSuChoi()
        {
            i = 1;
            try
            {
                using (StreamReader reader = new StreamReader(LichSuChoi))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "")
                            continue;
                        Console.WriteLine("Lần {0}: {1}", i, line);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại ReadLichSuChoi(): " + ex);
            }
        }
        public void WriteLichSuChoi(string playerName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(LichSuChoi, true))
                {
                    writer.WriteLine("{0} WIN", playerName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại WriteLichSuChoi(): " + ex);
            }
        }
    }
}